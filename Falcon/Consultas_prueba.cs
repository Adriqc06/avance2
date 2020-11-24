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
    public partial class Consultas_prueba : Form
    {
        public Consultas_prueba()
        {
            InitializeComponent();
        }

        private void Consultas_prueba_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pruebas ModForm = new Pruebas();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }
    }
}
