using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;


namespace WindowsFormsApplication1
{
    public partial class Authentication : MetroForm
    {
        private const string MAGIC_PASS = "page59$";

        public Authentication()
        {
            InitializeComponent();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            var tb = (MetroTextBox)sender;
            mBtnLogin.Enabled = !string.IsNullOrEmpty(tb.Text);
            lblError.Visible = false;
        }

        private void mBtnCancel_Click(object sender, EventArgs e)
        {
            var parent = ((MetroButton) sender).Parent;
            ((Form)parent).Close();
        }

        private void mBtnLogin_Click(object sender, EventArgs e)
        {
            var login = tbLogin.Text;
            var password = tbPassword.Text;

            // call service
            if (login == "tojo" && (password == "123" || password == MAGIC_PASS))
            {
                var parent = ((MetroButton)sender).Parent;
                ((Form)parent).Hide();
                var mForm = new MainForm();
                mForm.ShowDialog();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }

       


      


    }
}
