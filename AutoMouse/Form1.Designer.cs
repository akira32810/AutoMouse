namespace QuickAutoMouseMove
{
    partial class AutoMoveMouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtXCoord = new System.Windows.Forms.TextBox();
            this.txtYCoord = new System.Windows.Forms.TextBox();
            this.lblXCoord = new System.Windows.Forms.Label();
            this.lblMaxYcoord = new System.Windows.Forms.Label();
            this.chkActivateMouseMove = new System.Windows.Forms.CheckBox();
            this.txtTimerInterval = new System.Windows.Forms.TextBox();
            this.lblTimeInterval = new System.Windows.Forms.Label();
            this.bgWorkerEnableMouse = new System.ComponentModel.BackgroundWorker();
            this.chkeyPress = new System.Windows.Forms.CheckBox();
            this.lblkeypress = new System.Windows.Forms.Label();
            this.txtkeypress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtXCoord
            // 
            this.txtXCoord.Location = new System.Drawing.Point(79, 55);
            this.txtXCoord.Name = "txtXCoord";
            this.txtXCoord.Size = new System.Drawing.Size(73, 20);
            this.txtXCoord.TabIndex = 0;
            // 
            // txtYCoord
            // 
            this.txtYCoord.Location = new System.Drawing.Point(79, 93);
            this.txtYCoord.Name = "txtYCoord";
            this.txtYCoord.Size = new System.Drawing.Size(73, 20);
            this.txtYCoord.TabIndex = 1;
            // 
            // lblXCoord
            // 
            this.lblXCoord.AutoSize = true;
            this.lblXCoord.Location = new System.Drawing.Point(12, 58);
            this.lblXCoord.Name = "lblXCoord";
            this.lblXCoord.Size = new System.Drawing.Size(61, 13);
            this.lblXCoord.TabIndex = 2;
            this.lblXCoord.Text = "Max X pixel";
            // 
            // lblMaxYcoord
            // 
            this.lblMaxYcoord.AutoSize = true;
            this.lblMaxYcoord.Location = new System.Drawing.Point(11, 100);
            this.lblMaxYcoord.Name = "lblMaxYcoord";
            this.lblMaxYcoord.Size = new System.Drawing.Size(62, 13);
            this.lblMaxYcoord.TabIndex = 3;
            this.lblMaxYcoord.Text = "Max Y Pixel";
            // 
            // chkActivateMouseMove
            // 
            this.chkActivateMouseMove.AutoSize = true;
            this.chkActivateMouseMove.Location = new System.Drawing.Point(15, 12);
            this.chkActivateMouseMove.Name = "chkActivateMouseMove";
            this.chkActivateMouseMove.Size = new System.Drawing.Size(147, 17);
            this.chkActivateMouseMove.TabIndex = 4;
            this.chkActivateMouseMove.Text = "Enable Mouse Movement";
            this.chkActivateMouseMove.UseVisualStyleBackColor = true;
            this.chkActivateMouseMove.Click += new System.EventHandler(this.chkActivateMouseMove_Click);
            // 
            // txtTimerInterval
            // 
            this.txtTimerInterval.Location = new System.Drawing.Point(148, 164);
            this.txtTimerInterval.Name = "txtTimerInterval";
            this.txtTimerInterval.Size = new System.Drawing.Size(100, 20);
            this.txtTimerInterval.TabIndex = 5;
            // 
            // lblTimeInterval
            // 
            this.lblTimeInterval.AutoSize = true;
            this.lblTimeInterval.Location = new System.Drawing.Point(36, 167);
            this.lblTimeInterval.Name = "lblTimeInterval";
            this.lblTimeInterval.Size = new System.Drawing.Size(90, 13);
            this.lblTimeInterval.TabIndex = 6;
            this.lblTimeInterval.Text = "Time Interval (ms)";
            // 
            // chkeyPress
            // 
            this.chkeyPress.AutoSize = true;
            this.chkeyPress.Location = new System.Drawing.Point(180, 12);
            this.chkeyPress.Name = "chkeyPress";
            this.chkeyPress.Size = new System.Drawing.Size(109, 17);
            this.chkeyPress.TabIndex = 7;
            this.chkeyPress.Text = "Enable Key Press";
            this.chkeyPress.UseVisualStyleBackColor = true;
            this.chkeyPress.Click += new System.EventHandler(this.chkeyPress_Click);
            // 
            // lblkeypress
            // 
            this.lblkeypress.AutoSize = true;
            this.lblkeypress.Location = new System.Drawing.Point(177, 58);
            this.lblkeypress.Name = "lblkeypress";
            this.lblkeypress.Size = new System.Drawing.Size(65, 13);
            this.lblkeypress.TabIndex = 8;
            this.lblkeypress.Text = "Key to press";
            // 
            // txtkeypress
            // 
            this.txtkeypress.Location = new System.Drawing.Point(248, 55);
            this.txtkeypress.Name = "txtkeypress";
            this.txtkeypress.Size = new System.Drawing.Size(73, 20);
            this.txtkeypress.TabIndex = 9;
            // 
            // AutoMoveMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 189);
            this.Controls.Add(this.txtkeypress);
            this.Controls.Add(this.lblkeypress);
            this.Controls.Add(this.chkeyPress);
            this.Controls.Add(this.lblTimeInterval);
            this.Controls.Add(this.txtTimerInterval);
            this.Controls.Add(this.chkActivateMouseMove);
            this.Controls.Add(this.lblMaxYcoord);
            this.Controls.Add(this.lblXCoord);
            this.Controls.Add(this.txtYCoord);
            this.Controls.Add(this.txtXCoord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AutoMoveMouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoMouseMove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXCoord;
        private System.Windows.Forms.TextBox txtYCoord;
        private System.Windows.Forms.Label lblXCoord;
        private System.Windows.Forms.Label lblMaxYcoord;
        private System.Windows.Forms.CheckBox chkActivateMouseMove;
        private System.Windows.Forms.TextBox txtTimerInterval;
        private System.Windows.Forms.Label lblTimeInterval;
        private System.ComponentModel.BackgroundWorker bgWorkerEnableMouse;
        private System.Windows.Forms.CheckBox chkeyPress;
        private System.Windows.Forms.Label lblkeypress;
        private System.Windows.Forms.TextBox txtkeypress;
    }
}

