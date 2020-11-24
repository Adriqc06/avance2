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
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form6 ModForm = new Form6();
            //this.Hide();
            //ModForm.ShowDialog();
            //this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas_prueba ModForm = new Consultas_prueba();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultas_paquetería ModForm = new Consultas_paquetería();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login ModForm = new Login();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel_menus.Visible == false)
            {
                panel_menus.Visible = true;
            }
            else
            {
                panel_menus.Visible = false;
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login ModForm = new Login();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Consultas_prueba ModForm = new Consultas_prueba();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }
    }
}
