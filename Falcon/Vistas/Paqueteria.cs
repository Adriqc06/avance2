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
    public partial class Paqueteria : Form
    {
        public Paqueteria()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        BaseDeDatos bd = new BaseDeDatos();

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
            //Form1 ModForm = new Form1();
            //this.Hide();
            //ModForm.ShowDialog();
            //this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultas_paquetería ModForm = new Consultas_paquetería();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void Paqueteria_Load(object sender, EventArgs e)
        {

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login ModForm = new Login();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Consultas_paquetería ModForm = new Consultas_paquetería();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void bnt_agregar_Click(object sender, EventArgs e)
        {
            //string agregar = "insert into Paqueteria values(" + tb_guia.Text + ",'" + dt_fecha.Text + "','" + cb_paqueteria.Text + "'," + tb_temperatura.Text + ",'"+cb_proveedor.Text+"',"+tb_factura.Text+","+tb_paquetes.Text+")";
            string agregar = "insert into Paqueteria values(" + tb_guia.Text + ",'" + dt_fecha2.Text + "','" + cb_paqueteria2.Text + "','" + tb_temperatura2.Text + "','" + cb_proveedor2.Text + "','" + tb_factura2.Text + "'," + tb_paquetes2.Text + ")";

            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Registro agregado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar");
            }
            tb_guia.Text = "";
            dt_fecha2.Text = "";
            cb_paqueteria2.Text = "";
            tb_temperatura2.Text = "";
            cb_proveedor2.Text = "";
            tb_factura2.Text = "";
            tb_paquetes2.Text = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (tb_guia.Text == "")
            {
                MessageBox.Show("Introduzca un numero de guia para continuar");
            }
            string eliminar = "delete Paqueteria where Guia=" + tb_guia.Text;
            if (bd.executecommand(eliminar))
            {
                MessageBox.Show("Registro eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar");

            }
            tb_guia.Text = "";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tb_guia.Text = "";
            dt_fecha2.Text = "";
            cb_paqueteria2.Text = "";
            tb_temperatura2.Text = "";
            cb_proveedor2.Text = "";
            tb_factura2.Text = "";
            tb_paquetes2.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_paqueteria.DataSource = bd.SelectDataTable("select * from Paqueteria");

        }
    }
    }

