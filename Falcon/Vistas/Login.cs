using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Singleton;
using System.Data.SqlClient;


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
            Acceso_Chain_of_responsability cosa = new Acceso_Chain_of_responsability();
            cosa.logear(this.user.Text, this.password.Text);
            this.Close();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
