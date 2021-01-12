using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falcon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
      
        private void Form6_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string usuario_sec = "ana";
            string pass_sec = "ana";
            string usuario_ger = "maria";
            string pass_ger = "maria";

            if (user.Text == usuario_sec && password.Text == pass_sec)
            {
                Pruebas ModForm = new Pruebas();
                MessageBox.Show("Bienvenido");
                this.Hide();
                ModForm.ShowDialog();
                this.Show();
            }
            if (user.Text == usuario_ger && password.Text == pass_ger)
            {
                Paqueteria ModForm = new Paqueteria();
                MessageBox.Show("Bienvenido");
                this.Hide();
                ModForm.ShowDialog();
                this.Show();
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
