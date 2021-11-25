//using Gtk;
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ip_text = new System.Windows.Forms.TextBox();
            this.connection = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.videoDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect IP : ";
            // 
            // ip_text
            // 
            this.ip_text.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ip_text.Location = new System.Drawing.Point(224, 25);
            this.ip_text.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ip_text.Name = "ip_text";
            this.ip_text.Size = new System.Drawing.Size(455, 47);
            this.ip_text.TabIndex = 1;
            this.ip_text.Text = "rtsp://127.0.0.1:8554/test";
            // 
            // connection
            // 
            this.connection.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.connection.ForeColor = System.Drawing.Color.Red;
            this.connection.Location = new System.Drawing.Point(701, 25);
            this.connection.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(248, 58);
            this.connection.TabIndex = 2;
            this.connection.Text = "disconnected";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // videoDisplay
            // 
            this.videoDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoDisplay.Location = new System.Drawing.Point(24, 190);
            this.videoDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.videoDisplay.Name = "videoDisplay";
            this.videoDisplay.Size = new System.Drawing.Size(2459, 1260);
            this.videoDisplay.TabIndex = 3;
            this.videoDisplay.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2507, 1472);
            this.Controls.Add(this.videoDisplay);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.ip_text);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ip_text;
        private System.Windows.Forms.Button connection;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox videoDisplay;
        //private Gtk.DrawingArea draw;
    }
}

