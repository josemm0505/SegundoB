using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLSegundoB;

namespace FrmLogIn.cs
{
    public partial class frmLogIn : Form
    {
        ClsLogIn LogIn =new ClsLogIn();
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (LogIn.autenticar(txtusuario.Text, txtclave.Text)==true)
            {
               //MessageBox.Show("Ingreso Exitoso");
               frmPrincipal principal1 = new frmPrincipal();
                this.Hide();
                principal1.Show();
            }
            else
            {
                MessageBox.Show("Ingreso Fallido");
                Close();
            }
        }
    }
}
