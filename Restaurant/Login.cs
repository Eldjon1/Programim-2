using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if  (Class1.PerdoruesAktiv(txtPerdoruesi.Text, txtFjalekalimi.Text) ==false )
            {
                message.Show("Perdoruesi ose Fjalekalimi i pa sakte");
                return;
            }
            else
            {
                this.Hide();
                KryesoreFrm k = new KryesoreFrm();
                k.Show();
            }
        }

        private void txtPerdoruesi_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
