namespace WindowsFormsApplication1
{
    partial class Authentication
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
            this.mLblLogin = new MetroFramework.Controls.MetroLabel();
            this.mLblPwd = new MetroFramework.Controls.MetroLabel();
            this.mBtnLogin = new MetroFramework.Controls.MetroButton();
            this.mBtnCancel = new MetroFramework.Controls.MetroButton();
            this.tbLogin = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblError = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mLblLogin
            // 
            this.mLblLogin.AutoSize = true;
            this.mLblLogin.Location = new System.Drawing.Point(43, 73);
            this.mLblLogin.Name = "mLblLogin";
            this.mLblLogin.Size = new System.Drawing.Size(41, 19);
            this.mLblLogin.TabIndex = 7;
            this.mLblLogin.Text = "Login";
            // 
            // mLblPwd
            // 
            this.mLblPwd.AutoSize = true;
            this.mLblPwd.Location = new System.Drawing.Point(45, 105);
            this.mLblPwd.Name = "mLblPwd";
            this.mLblPwd.Size = new System.Drawing.Size(64, 19);
            this.mLblPwd.TabIndex = 8;
            this.mLblPwd.Text = "Password";
            // 
            // mBtnLogin
            // 
            this.mBtnLogin.Enabled = false;
            this.mBtnLogin.Location = new System.Drawing.Point(248, 167);
            this.mBtnLogin.Name = "mBtnLogin";
            this.mBtnLogin.Size = new System.Drawing.Size(75, 23);
            this.mBtnLogin.TabIndex = 9;
            this.mBtnLogin.Text = "Valider";
            this.mBtnLogin.UseSelectable = true;
            this.mBtnLogin.Click += new System.EventHandler(this.mBtnLogin_Click);
            // 
            // mBtnCancel
            // 
            this.mBtnCancel.Location = new System.Drawing.Point(329, 166);
            this.mBtnCancel.Name = "mBtnCancel";
            this.mBtnCancel.Size = new System.Drawing.Size(75, 23);
            this.mBtnCancel.TabIndex = 10;
            this.mBtnCancel.Text = "Annuler";
            this.mBtnCancel.UseSelectable = true;
            this.mBtnCancel.Click += new System.EventHandler(this.mBtnCancel_Click);
            // 
            // tbLogin
            // 
            // 
            // 
            // 
            this.tbLogin.CustomButton.Image = null;
            this.tbLogin.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.tbLogin.CustomButton.Name = "";
            this.tbLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLogin.CustomButton.TabIndex = 1;
            this.tbLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLogin.CustomButton.UseSelectable = true;
            this.tbLogin.CustomButton.Visible = false;
            this.tbLogin.Lines = new string[0];
            this.tbLogin.Location = new System.Drawing.Point(136, 68);
            this.tbLogin.MaxLength = 32767;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PasswordChar = '\0';
            this.tbLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLogin.SelectedText = "";
            this.tbLogin.SelectionLength = 0;
            this.tbLogin.SelectionStart = 0;
            this.tbLogin.ShortcutsEnabled = true;
            this.tbLogin.Size = new System.Drawing.Size(267, 23);
            this.tbLogin.TabIndex = 11;
            this.tbLogin.UseSelectable = true;
            this.tbLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(245, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(136, 105);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(267, 23);
            this.tbPassword.TabIndex = 12;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(136, 138);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(88, 19);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Accès refusée";
            this.lblError.Visible = false;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(461, 211);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.mBtnCancel);
            this.Controls.Add(this.mBtnLogin);
            this.Controls.Add(this.mLblPwd);
            this.Controls.Add(this.mLblLogin);
            this.Name = "Authentication";
            this.Resizable = false;
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private MetroFramework.Controls.MetroLabel mLblLogin;
        private MetroFramework.Controls.MetroLabel mLblPwd;
        private MetroFramework.Controls.MetroButton mBtnLogin;
        private MetroFramework.Controls.MetroButton mBtnCancel;
        private MetroFramework.Controls.MetroTextBox tbLogin;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroLabel lblError;

    }
}