using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gst;
using GLib;
using Gst.Video;
using GtkSharp;
namespace RTP
{
    public partial class Form1 : Form
    {
        Element videoSource, rtpdepay, decode, videoSink;

        GLib.MainLoop mainLoop;
        System.Threading.Thread glibThread;
        IntPtr videoPanelHandle;
        uint refreshUiHandle;
        long duration = -1;
        Pipeline pipeline = null;

        enum ConnectStatus { connect = 1, disconnect = 0 };
        int connect_status;

        public Form1()
        {
            InitializeComponent();

            gstreamer_init();
        }
        private void gstreamer_init()
        {
            Gst.Application.Init();
            GtkSharp.GstreamerSharp.ObjectManager.Initialize();
            videoPanel.HandleCreated += HandleRealized;
            InitGStreamerPipeline();

        }

        void HandleRealized(object sender, System.EventArgs e)
        {
            var vpanel = sender as Panel;
            videoPanelHandle = vpanel.Handle;

            Element overlay = ((Gst.Bin)pipeline).GetByInterface(VideoOverlayAdapter.GType);
            VideoOverlayAdapter adapter = new VideoOverlayAdapter(overlay.Handle);
            //System.Diagnostics.Debug.WriteLine("handle msg: "+ adapter.);

            adapter.HandleEvents(true);
            adapter.WindowHandle = videoPanelHandle;
        }

        void InitGStreamerPipeline()
        {
            mainLoop = new GLib.MainLoop();
            glibThread = new System.Threading.Thread(mainLoop.Run);
            glibThread.Start();

            // Create the elements
            videoSource = ElementFactory.Make("udpsrc", "udpsrc");
            rtpdepay = ElementFactory.Make("rtph264depay", "filter");
            decode = ElementFactory.Make("avdec_h264", "decode");
            videoSink = ElementFactory.Make("autovideosink", "autovideosink");
            pipeline = new Pipeline("mainpipe");
            //ElementFactory.Make("playbin", "playbin")
            //Parse.Launch(@"videotestsrc ! autovideosink")
            if (pipeline == null)
            {
                System.Diagnostics.Debug.WriteLine("Not all elements could be created");
                return;
            }
            //pipeline.Add(videoSource, videoSink);
            pipeline.Add(videoSource, rtpdepay, decode, videoSink);
            if (!videoSource.Link(rtpdepay))
                System.Diagnostics.Debug.WriteLine("Cannot link elements videoSink, rtpdepay");
            if (!rtpdepay.Link(decode))
                System.Diagnostics.Debug.WriteLine("Cannot link elements videoSink, rtpdepay");
            if (!decode.Link(videoSink))
                System.Diagnostics.Debug.WriteLine("Cannot link elements videoSink, rtpdepay");
            //if (!Element.Link(videoSink, rtpdepay, decode, videoSink))
            //{
            //    System.Diagnostics.Debug.WriteLine("Cannot link elements");
            //    //return;
            //}



            // Set the URI to play.
            
            //Caps cap =Gst.Global.CapsFromString($"video/x-raw, width=(int)1280, height=(int)720");

            // @"application/x-rtp, media=video, clock-rate=90000, encoding-nam e=H264, payload=96"
            //videoSource.AddPadTemplate(new PadTemplate("srctpl", PadDirection.Src, PadPresence.Always,cap));
            //PadTemplate pt = new PadTemplate("src", PadDirection.Src, PadPresence.Always, Gst.Global.CapsFromString("video/x-raw, width=1280, height=720"));
            var s = videoSource.GetProperty("caps");
            videoSource.SetProperty("port", new GLib.Value(8787));
            s = videoSource.GetProperty("port");
            
            videoSource.SetProperty("caps", new GLib.Value(Gst.Global.CapsFromString(@"application/x-rtp, media=video, clock-rate=90000, encoding-name=H264, payload=96")));
            s = videoSource.GetProperty("caps");
            

            var bus = pipeline.Bus;
            bus.AddSignalWatch();
            bus.Connect("message::error", ErrorCb);
            bus.Connect("message::eos", EosCb);
            bus.Connect("message::state-changed", StateChangedCb);
            bus.Connect("message::application", ApplicationCb);

            pipeline.SetState(State.Null);
            pipeline.SetState(State.Ready);

            //refreshUiHandle = GLib.Timeout.Add(1, RefreshUI);
        }

        #region Bus events
        /// <summary>
        /// This function is called when an error message is posted on the bus
        /// </summary>
        void ErrorCb(object o, GLib.SignalArgs args)
        {
            Gst.Message msg = (Gst.Message)args.Args[0];
            msg.ParseError(out GException err, out string debug);

            System.Diagnostics.Debug.WriteLine($"Error received from element {msg.Src.Name}: {err.Message}");
            System.Diagnostics.Debug.WriteLine("Debugging information: {0}", debug ?? "(none)");

            pipeline.SetState(State.Ready);
        }

        void EosCb(object o, SignalArgs args)
        {
            System.Diagnostics.Debug.WriteLine("End-Of-Stream reached.");
            pipeline.SetState(State.Ready);
        }

        void StateChangedCb(object o, SignalArgs args)
        {
            var msg = (Gst.Message)args.Args[0];
            msg.ParseStateChanged(out State oldState, out State newState, out State pendingState);
            if (msg.Src == pipeline)
            {
                Console.WriteLine($"State set to {Element.StateGetName(newState)}");
                //if (oldState == State.Ready && newState == State.Paused)
                //{
                //    // For extra responsiveness, we refresh the GUI as soon as we reach the PAUSED state
                //    RefreshUI();
                //}
            }
        }

        void ApplicationCb(object o, SignalArgs args)
        {
            var msg = (Gst.Message)args.Args[0];
            if (msg.Structure.Name == "tags-changed")
            {
                // If the message is the "tags-changed" (only one we are currently issuing), update the stream info GUI
                //AnalyzeStreams();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GLib.Timeout.Remove(refreshUiHandle);
            pipeline.SetState(State.Ready);
            pipeline.SetState(State.Null);

            //System.Threading.Thread.Sleep(10);
            mainLoop.Quit();
        }
        #endregion

        void TagsCb(object sender, GLib.SignalArgs args)
        {
            var playbin = sender as Element;
            // We are possibly in the Gstreamer working thread, so we notify the main thread of this event through a message in the bus
            var s = new Structure("tags-changed");
            playbin.PostMessage(Gst.Message.NewApplication(playbin, s));
        }
        //bool RefreshUI()
        //{
        //    if (videoSink == null)
        //        return false;
        //    videoSink.GetState(out State state, out State pending, 100);

        //    // We do not want to update anything unless we are in the PAUSED or PLAYING states
        //    if (state != State.Playing && state != State.Paused)
        //    {
        //        return true;
        //    }

        //    if (duration < 0)
        //    {
        //        if (!videoSink.QueryDuration(Format.Time, out duration))
        //            System.Diagnostics.Debug.WriteLine("Could not query the current duration.");
        //        else
        //        {
        //            Action updateSlider = () =>
        //            {
        //                //Set the range of the slider to the clip duration, in SECONDS
        //                slider.Minimum = 0;
        //                slider.Maximum = (int)(duration / Gst.Constants.SECOND);
        //            };
        //            if (slider.InvokeRequired)
        //            {
        //                slider.Invoke(updateSlider);
        //            }
        //        }
        //    }
        //    if (videoSink.QueryPosition(Format.Time, out long current))
        //    {
        //        try
        //        {
        //            /* Block the "value-changed" signal, so the slider_cb function is not called
        //                * (which would trigger a seek the user has not requested) */
        //            slider.ValueChanged -= OnSliderValueChanged;
        //            slider.Invoke((Action)(() => slider.Value = (int)(current / Gst.Constants.SECOND)));
        //            slider.ValueChanged += OnSliderValueChanged;
        //        }
        //        catch (System.ComponentModel.InvalidAsynchronousStateException)
        //        {
        //            // An error occurred invoking the method.  The destination thread no longer exists
        //        }
        //    }
        //    return true;
        //}



        private void connectButton_Click(object sender, System.EventArgs e)
        {
            //InitGStreamerPipeline();

            if (connect_status > 0)    //connect
            {
                ipText.ReadOnly = false;
                connectButton.Text = "disconnected";
                connectButton.ForeColor = Color.Red;
                connect_status = (int)ConnectStatus.disconnect;
                var ret = pipeline.SetState(State.Paused);
                if (ret == StateChangeReturn.Failure)
                {
                    System.Diagnostics.Debug.WriteLine("Unable to set the pipeline to the playing state.");
                    return;
                }
            }
            else
            {                       //disconnect
                ipText.ReadOnly = true;
                connectButton.Text = "connectting";
                connectButton.ForeColor = Color.SeaGreen;
                connect_status = (int)ConnectStatus.connect;
                var ret = pipeline.SetState(State.Playing);
                if (ret == StateChangeReturn.Failure)
                {
                    System.Diagnostics.Debug.WriteLine("Unable to set the pipeline to the playing state.");
                    return;
                }
            }
        }


    }
}
