using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Falcon
{
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void Pruebas_Load(object sender, EventArgs e)
        {
           

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
            if (panel_menus.Visible == true)
            {
                panel_menus.Visible = false;
            }
            else
            {
                panel_menus.Visible = true;
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
      

        private void bnt_agregar_Click(object sender, EventArgs e)
        {

            string agregar = "insert into prueba values(" + tb_id.Text + ",'" + dt_fecha.Text + "','"+cb_tipoprueba.Text+"',"+tb_cantidad.Text+")";
            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Registro agregado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar");
            }
            tb_id.Text = "";
            dt_fecha.Text = "";
            cb_tipoprueba.Text = "";
            tb_cantidad.Text = "";
        }
     

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("Introduzca un ID para continuar");
            }
            string eliminar = "delete prueba where ID=" + tb_id.Text;
            if (bd.executecommand(eliminar))
            {
                MessageBox.Show("Registro eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
            tb_id.Text = "";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            dt_fecha.Text = "";
            cb_tipoprueba.Text = "";
            tb_cantidad.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            dgv_pruebas.DataSource = bd.SelectDataTable("select * from prueba");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Consultas_prueba ModForm = new Consultas_prueba();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void panel_menus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_pruebas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
