namespace JacobsRDC
{
    partial class NewConnection
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
            this.ConNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PortTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConNameTb
            // 
            this.ConNameTb.Location = new System.Drawing.Point(12, 32);
            this.ConNameTb.Name = "ConNameTb";
            this.ConNameTb.Size = new System.Drawing.Size(176, 20);
            this.ConNameTb.TabIndex = 0;
            this.ConNameTb.Text = "Bot01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of connection:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP address or DNS name:";
            // 
            // IPTb
            // 
            this.IPTb.Location = new System.Drawing.Point(12, 85);
            this.IPTb.Name = "IPTb";
            this.IPTb.Size = new System.Drawing.Size(176, 20);
            this.IPTb.TabIndex = 2;
            this.IPTb.Text = "142.44.156.241";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port:";
            // 
            // PortTb
            // 
            this.PortTb.Enabled = false;
            this.PortTb.Location = new System.Drawing.Point(12, 136);
            this.PortTb.Name = "PortTb";
            this.PortTb.Size = new System.Drawing.Size(176, 20);
            this.PortTb.TabIndex = 4;
            this.PortTb.Text = "4899";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(216, 85);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(176, 20);
            this.PasswordTb.TabIndex = 9;
            this.PasswordTb.Text = "5fc1679edd58D$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username:";
            // 
            // UsernameTb
            // 
            this.UsernameTb.Location = new System.Drawing.Point(216, 32);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(176, 20);
            this.UsernameTb.TabIndex = 7;
            this.UsernameTb.Text = "Administrator";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(308, 130);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(84, 30);
            this.OkBtn.TabIndex = 11;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(216, 130);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(84, 30);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NewConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 175);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PortTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IPTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConNameTb);
            this.Name = "NewConnection";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PortTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UsernameTb;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}