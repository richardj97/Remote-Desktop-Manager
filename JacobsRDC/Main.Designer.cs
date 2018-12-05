namespace JacobsRDC
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.NavPanel = new System.Windows.Forms.Panel();
            this.ConnectionsFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.RDCPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SettingsBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.FullScreenBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.StopBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.AddConnectionBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.RDCClient = new AxMSTSCLib.AxMsRdpClient9NotSafeForScripting();
            this.NavPanel.SuspendLayout();
            this.RDCPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreenBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddConnectionBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDCClient)).BeginInit();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.White;
            this.NavPanel.Controls.Add(this.SettingsBtn);
            this.NavPanel.Controls.Add(this.FullScreenBtn);
            this.NavPanel.Controls.Add(this.StopBtn);
            this.NavPanel.Controls.Add(this.AddConnectionBtn);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(360, 83);
            this.NavPanel.TabIndex = 0;
            // 
            // ConnectionsFLP
            // 
            this.ConnectionsFLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionsFLP.BackColor = System.Drawing.SystemColors.Control;
            this.ConnectionsFLP.Location = new System.Drawing.Point(12, 103);
            this.ConnectionsFLP.Name = "ConnectionsFLP";
            this.ConnectionsFLP.Size = new System.Drawing.Size(336, 312);
            this.ConnectionsFLP.TabIndex = 1;
            // 
            // RDCPanel
            // 
            this.RDCPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RDCPanel.Controls.Add(this.RDCClient);
            this.RDCPanel.Location = new System.Drawing.Point(0, 83);
            this.RDCPanel.Name = "RDCPanel";
            this.RDCPanel.Size = new System.Drawing.Size(362, 344);
            this.RDCPanel.TabIndex = 2;
            this.RDCPanel.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(360, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(110, 17);
            this.StatusLabel.Text = "Status: Not running";
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.Image = global::JacobsRDC.Properties.Resources.settings_icon_N_dark;
            this.SettingsBtn.ImageActive = null;
            this.SettingsBtn.Location = new System.Drawing.Point(284, 12);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(58, 57);
            this.SettingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.TabStop = false;
            this.SettingsBtn.Zoom = 10;
            // 
            // FullScreenBtn
            // 
            this.FullScreenBtn.BackColor = System.Drawing.Color.Transparent;
            this.FullScreenBtn.Enabled = false;
            this.FullScreenBtn.Image = global::JacobsRDC.Properties.Resources.computer3;
            this.FullScreenBtn.ImageActive = null;
            this.FullScreenBtn.Location = new System.Drawing.Point(194, 12);
            this.FullScreenBtn.Name = "FullScreenBtn";
            this.FullScreenBtn.Size = new System.Drawing.Size(58, 57);
            this.FullScreenBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FullScreenBtn.TabIndex = 2;
            this.FullScreenBtn.TabStop = false;
            this.FullScreenBtn.Zoom = 10;
            this.FullScreenBtn.Click += new System.EventHandler(this.FullScreenBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.Transparent;
            this.StopBtn.Enabled = false;
            this.StopBtn.Image = global::JacobsRDC.Properties.Resources.computer2;
            this.StopBtn.ImageActive = null;
            this.StopBtn.Location = new System.Drawing.Point(103, 12);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(58, 57);
            this.StopBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopBtn.TabIndex = 1;
            this.StopBtn.TabStop = false;
            this.StopBtn.Zoom = 10;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // AddConnectionBtn
            // 
            this.AddConnectionBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddConnectionBtn.Image = global::JacobsRDC.Properties.Resources.add_computer_icon_32577;
            this.AddConnectionBtn.ImageActive = null;
            this.AddConnectionBtn.Location = new System.Drawing.Point(12, 12);
            this.AddConnectionBtn.Name = "AddConnectionBtn";
            this.AddConnectionBtn.Size = new System.Drawing.Size(58, 57);
            this.AddConnectionBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddConnectionBtn.TabIndex = 0;
            this.AddConnectionBtn.TabStop = false;
            this.AddConnectionBtn.Zoom = 10;
            this.AddConnectionBtn.Click += new System.EventHandler(this.AddConnectionBtn_Click);
            // 
            // RDCClient
            // 
            this.RDCClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RDCClient.Enabled = true;
            this.RDCClient.Location = new System.Drawing.Point(-1, -1);
            this.RDCClient.Name = "RDCClient";
            this.RDCClient.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("RDCClient.OcxState")));
            this.RDCClient.Size = new System.Drawing.Size(363, 347);
            this.RDCClient.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 452);
            this.Controls.Add(this.RDCPanel);
            this.Controls.Add(this.NavPanel);
            this.Controls.Add(this.ConnectionsFLP);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JacobsRDC - Remote Desktop Connection";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.NavPanel.ResumeLayout(false);
            this.RDCPanel.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreenBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddConnectionBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDCClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.FlowLayoutPanel ConnectionsFLP;
        private Bunifu.Framework.UI.BunifuImageButton AddConnectionBtn;
        private System.Windows.Forms.Panel RDCPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private Bunifu.Framework.UI.BunifuImageButton StopBtn;
        private Bunifu.Framework.UI.BunifuImageButton FullScreenBtn;
        private Bunifu.Framework.UI.BunifuImageButton SettingsBtn;
        private AxMSTSCLib.AxMsRdpClient9NotSafeForScripting RDCClient;
    }
}

