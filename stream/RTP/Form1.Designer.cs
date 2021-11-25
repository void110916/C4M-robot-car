
namespace RTP
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
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
                pipeline.Dispose();
                pipeline = null;
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
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.streamsList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(15, 17);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(77, 16);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "Connect IP : ";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(98, 11);
            this.ipText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(151, 23);
            this.ipText.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.ForeColor = System.Drawing.Color.Red;
            this.connectButton.Location = new System.Drawing.Point(255, 9);
            this.connectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(93, 26);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "disconnected";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // videoPanel
            // 
            this.videoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPanel.Location = new System.Drawing.Point(10, 68);
            this.videoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(936, 604);
            this.videoPanel.TabIndex = 3;
            // 
            // streamsList
            // 
            this.streamsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streamsList.Location = new System.Drawing.Point(946, 68);
            this.streamsList.Margin = new System.Windows.Forms.Padding(0);
            this.streamsList.Multiline = true;
            this.streamsList.Name = "streamsList";
            this.streamsList.Size = new System.Drawing.Size(309, 604);
            this.streamsList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.streamsList);
            this.Controls.Add(this.videoPanel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.ipLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.TextBox streamsList;
    }
}

