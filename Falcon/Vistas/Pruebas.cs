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
using System.Runtime.InteropServices;

namespace Falcon
{
    public partial class Pruebas : Form
    {

        public Pruebas()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wnsg, int wparam, int lparam);

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
            if (tb_id.Text == "")
            {
                MessageBox.Show("Introduzca un ID para continuar");
            }else {
                string agregar = "insert into prueba values(" + tb_id.Text + ",'" + dt_fecha.Text + "','" + cb_tipoprueba.Text + "'," + tb_cantidad.Text + ")";
                if (bd.executecommand(agregar))
                {
                    MessageBox.Show("Registro agregado correctamente");
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Error al insertar");
                }
            }
           
        }
     

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            panel8.Enabled = false;
            btn_modificar.Enabled = false;
            btn_Limpiar.Enabled = false;
            bnt_agregar.Enabled = false;

            if (tb_id.Text == "")
            {
                MessageBox.Show("Introduzca un ID para continuar");
            }
            string eliminar = "delete prueba where ID=" + tb_id.Text;
            if (bd.executecommand(eliminar))
            {
                MessageBox.Show("Registro eliminado correctamente");
                Refresh();
            }
           
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Refresh();
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

        private void Pruebas_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'falconDataSet3.Prueba' Puede moverla o quitarla según sea necesario.
            this.pruebaTableAdapter.Fill(this.falconDataSet3.Prueba);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_Limpiar.Enabled = false;
            bnt_agregar.Enabled = false;

            if (tb_id.Text == "" && tb_cantidad.Text=="")
            {
                MessageBox.Show("Introduzca un ID y la Cantidad a modificar para continuar ");

            }
            string actualizar = "update prueba set Cantidad=" + tb_cantidad.Text + "where ID=" + tb_id.Text;
            if (bd.executecommand(actualizar))
            {
                MessageBox.Show("Registro actualizado correctamente");
                Refresh();
            }
           
        }

        private void btn_Limpiar_Click_1(object sender, EventArgs e)
        {
            tb_id.Text = "";
            dt_fecha.Text = "";
            cb_tipoprueba.Text = "";
            tb_cantidad.Text = "";

        }

        //VALIDACIONES
        public void Refresh()
        {
            tb_id.Text = "";
            dt_fecha.Text = "";
            cb_tipoprueba.Text = "";
            tb_cantidad.Text = "";
            dgv_pruebas.DataSource = bd.SelectDataTable("select * from prueba");
            panel8.Enabled = true;
            panel3.Enabled = true;
            btn_modificar.Enabled = true;
            btn_Limpiar.Enabled = true;
            bnt_agregar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTituloPnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
