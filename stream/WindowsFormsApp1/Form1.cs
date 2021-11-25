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
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Element videoSource, rtpdepay,decode;
        Gst.App.AppSink appSink;
        static System.Threading.Thread threading;
        static GLib.MainLoop mainloop;
        IntPtr handle;
        VideoSink imageSink;
        Pipeline pipeline = null;

        public Form1()
        {
            InitializeComponent();
            connect_status = (int)ConnectStatus.disconnect;
            this.Load += gstream_init;
        }

        enum ConnectStatus { connect = 1, disconnect = 0 };
        int connect_status;

        private void connection_Click(object sender, System.EventArgs e)
        {
            if (connect_status > 0)    //connect
            {
                ip_text.ReadOnly = false;
                connection.Text = "disconnected";
                connection.ForeColor = Color.Red;
                connect_status = (int)ConnectStatus.disconnect;
            }
            else
            {                       //disconnect
                ip_text.ReadOnly = true;
                connection.Text = "connectting";
                connection.ForeColor = Color.SeaGreen;
                connect_status = (int)ConnectStatus.connect;
                
                gstream_set(ip_text.Text);
            }
        }

        void gstream_load(object sender, System.EventArgs e)    // unused
        {
            ThreadPool.QueueUserWorkItem(x =>
            {
                while (!IsDisposed)
                {
                    if (this.videoDisplay.IsHandleCreated)
                        continue;
                    //var sample = sink.TryPullSample(500);
                    //if (sample == null)
                    //    continue;
                    //else
                    //{

                    //}
                }
            });
        }
        void gstream_init(object sender, System.EventArgs e)
        {
            handle = videoDisplay.Handle;
            Gst.Application.Init();
            GtkSharp.GstreamerSharp.ObjectManager.Initialize();
            mainloop = new MainLoop();
            threading = new System.Threading.Thread(mainloop.Run);
            threading.Start();

            




            //System.Threading.ThreadPool.QueueUserWorkItem(x => mainloop.Run());

            //Element overlay = null;
            //if (videoSource is Gst.Bin)
            //    overlay = ((Gst.Bin)videoSource).GetByInterface(VideoOverlayAdapter.GType);
            //VideoOverlayAdapter stream = new VideoOverlayAdapter(overlay.Handle);
            //stream.WindowHandle = video_pannel1.Handle;
            //stream.HandleEvents(true);



        }

        private void gstream_set(string ip)
        {
            imageSink = (Gst.Video.VideoSink)Gst.ElementFactory.Make("directdrawsink", "directdrawsink");
            rtpdepay = ElementFactory.Make("rtph264depay", "rtph264depay");
            decode = ElementFactory.Make("avdec_h264", "avdec_h264");
            videoSource = ElementFactory.Make("udpsrc", "udpsrc");
            //videoSource["uri"] = ip;
            videoSource.PadAdded += HandlePadAdded;
            videoSource["port"] = 8787;
            
            
            videoSource["caps"] = Caps.FromString("application/x-rtp, media=(string)video, clock-rate=(int)90000, encoding-name=(string)H264, payload=(int)96");
            
            
            pipeline = new Pipeline("pipeline");
            pipeline.Add(videoSource, rtpdepay,decode, imageSink);
            if (!rtpdepay.Link(videoSource))
                System.Diagnostics.Debug.WriteLine("cannot link rtpdepay");
            if (!decode.Link(rtpdepay))
                System.Diagnostics.Debug.WriteLine("cannot link decode");
            if (!imageSink.Link(decode))
                System.Diagnostics.Debug.WriteLine("cannot link imageSink");

            Bus bus = pipeline.Bus;
            bus.AddSignalWatch();
            bus.Message += HandleMessage;
            bus.EnableSyncMessageEmission();
            bus.SyncMessage += new SyncMessageHandler(bus_SyncMessage);

            var setStateRate = pipeline.SetState(State.Null);
#if DEBUG
            System.Diagnostics.Debug.WriteLine("SetStateNULL returned: " + setStateRate.ToString());
#endif
            setStateRate = pipeline.SetState(State.Ready);
#if DEBUG
            System.Diagnostics.Debug.WriteLine("SetStateReady returned: " + setStateRate.ToString());
#endif
            setStateRate = pipeline.SetState(State.Playing);
        }
        void HandlePadAdded(object o, PadAddedArgs args)
        {
            var src = (Element)o;
            var newPad = args.NewPad;
            var sinkPad = rtpdepay.GetStaticPad("sink");

            Console.WriteLine(string.Format("Received new pad '{0}' from '{1}':", newPad.Name, src.Name));

            // If our converter is already linked, we have nothing to do here
            if (sinkPad.IsLinked)
            {
                Console.WriteLine("We are already linked. Ignoring.");
                return;
            }

            // Check the new pad's type
            var newPadCaps = newPad.Caps;
            var newPadStruct = newPadCaps.GetStructure(0);
            var newPadType = newPadStruct.Name;
            if (!newPadType.StartsWith("application/x-rtp"))
            {
                Console.WriteLine("It has type '{0}' which is not raw audio. Ignoring.", newPadType);
                return;
            }

            // Attempt the link
            var ret = newPad.Link(sinkPad);
            if (ret != PadLinkReturn.Ok)
                Console.WriteLine("Type is '{0} but link failed.", newPadType);
            else
                Console.WriteLine("Link succeeded (type '{0}').", newPadType);
        }
        private void bus_SyncMessage(object o, SyncMessageArgs args)
        {
            //Convenience function to check if the given message is a "prepare-window-handle" message from a GstVideoOverlay.

            System.Diagnostics.Debug.WriteLine("bus_SyncMessage: " + args.Message.Type.ToString());
            if (Gst.Video.Global.IsVideoOverlayPrepareWindowHandleMessage(args.Message))
            {
                Element src = (Gst.Element)args.Message.Src;

#if DEBUG
                System.Diagnostics.Debug.WriteLine("Message'prepare-window-handle' received by: " + src.Name + " " + src.ToString());
#endif

                if (src != null && (src is Gst.Video.VideoSink | src is Gst.Bin))
                {
                    //    Try to set Aspect Ratio
                    try
                    {
                        src["force-aspect-ratio"] = true;
                    }
                    catch (PropertyNotFoundException) { }

                    //    Try to set Overlay
                    try
                    {
                        Gst.Video.VideoOverlayAdapter overlay_ = new Gst.Video.VideoOverlayAdapter(src.Handle);
                        overlay_.WindowHandle = handle;
                        overlay_.HandleEvents(true);
                    }
                    catch (Exception ex) { System.Diagnostics.Debug.WriteLine("Exception thrown: " + ex.Message); }
                }
            }
        }

        private void bindingSource1_CurrentChanged(object sender, System.EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainloop.IsRunning is true)
                mainloop.Quit();
        }

        void HandleMessage(object o, MessageArgs args)
        {
            var msg = args.Message;
#if DEBUG
            System.Diagnostics.Debug.WriteLine("HandleMessage received msg of type: {0}", msg.Type);
#endif
            switch (msg.Type)
            {
                case MessageType.Error:
                    System.Diagnostics.Debug.WriteLine("Error received: " + msg.ToString());
                    break;
                case MessageType.StreamStatus:
                    Gst.StreamStatusType status;
                    Element owner;
                    msg.ParseStreamStatus(out status, out owner);
                    System.Diagnostics.Debug.WriteLine("Case SteamingStatus: status is: " + status + " ; Ownder is: " + owner.Name);
                    break;
                case MessageType.StateChanged:
                    State oldState, newState, pendingState;
                    msg.ParseStateChanged(out oldState, out newState, out pendingState);
                    if (newState == State.Paused)
                        args.RetVal = false;
#if DEBUG
                    System.Diagnostics.Debug.WriteLine("Pipeline state changed from {0} to {1}: ; Pending: {2}", Element.StateGetName(oldState), Element.StateGetName(newState), Element.StateGetName(pendingState));
#endif
                    break;
                case MessageType.Element:
                    System.Diagnostics.Debug.WriteLine("Element message: {0}", args.Message.ToString());
                    break;
                default:
                    System.Diagnostics.Debug.WriteLine("HandleMessage received msg of type: {0}", msg.Type);
                    break;


            }
            args.RetVal = true;
        }



    }
}
