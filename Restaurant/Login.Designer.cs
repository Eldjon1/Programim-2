namespace Restaurant
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPerdoruesi = new System.Windows.Forms.Label();
            this.lblFjalekalimi = new System.Windows.Forms.Label();
            this.txtFjalekalimi = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPerdoruesi = new System.Windows.Forms.TextBox();
            this.message = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 139);
            this.panel1.TabIndex = 5;
            // 
            // lblPerdoruesi
            // 
            this.lblPerdoruesi.AutoSize = true;
            this.lblPerdoruesi.Location = new System.Drawing.Point(141, 169);
            this.lblPerdoruesi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerdoruesi.Name = "lblPerdoruesi";
            this.lblPerdoruesi.Size = new System.Drawing.Size(94, 19);
            this.lblPerdoruesi.TabIndex = 3;
            this.lblPerdoruesi.Text = "Përdoruesi:";
            this.lblPerdoruesi.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFjalekalimi
            // 
            this.lblFjalekalimi.AutoSize = true;
            this.lblFjalekalimi.Location = new System.Drawing.Point(143, 252);
            this.lblFjalekalimi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFjalekalimi.Name = "lblFjalekalimi";
            this.lblFjalekalimi.Size = new System.Drawing.Size(96, 19);
            this.lblFjalekalimi.TabIndex = 4;
            this.lblFjalekalimi.Text = "Fjalëkalimi:";
            this.lblFjalekalimi.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtFjalekalimi
            // 
            this.txtFjalekalimi.Location = new System.Drawing.Point(89, 282);
            this.txtFjalekalimi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFjalekalimi.Name = "txtFjalekalimi";
            this.txtFjalekalimi.Size = new System.Drawing.Size(192, 26);
            this.txtFjalekalimi.TabIndex = 1;
            this.txtFjalekalimi.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.Location = new System.Drawing.Point(144, 334);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 52);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPerdoruesi
            // 
            this.txtPerdoruesi.Location = new System.Drawing.Point(89, 204);
            this.txtPerdoruesi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPerdoruesi.Name = "txtPerdoruesi";
            this.txtPerdoruesi.Size = new System.Drawing.Size(192, 26);
            this.txtPerdoruesi.TabIndex = 0;
            this.txtPerdoruesi.TextChanged += new System.EventHandler(this.txtPerdoruesi_TextChanged);
            // 
            // message
            // 
            this.message.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.message.Caption = "Restaurant";
            this.message.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.message.Parent = this;
            this.message.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.message.Text = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginFrm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(377, 458);
            this.Controls.Add(this.txtPerdoruesi);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtFjalekalimi);
            this.Controls.Add(this.lblFjalekalimi);
            this.Controls.Add(this.lblPerdoruesi);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPerdoruesi;
        private System.Windows.Forms.Label lblFjalekalimi;
        private System.Windows.Forms.TextBox txtFjalekalimi;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPerdoruesi;
        private Guna.UI2.WinForms.Guna2MessageDialog message;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

