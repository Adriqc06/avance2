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
    public partial class Modulo_usuarios : Form
    {
        public Modulo_usuarios()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void Modulo_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'falconDataSet6.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.falconDataSet6.Usuarios);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button2.Enabled = false;
            button3.Enabled = false;

            if (tb_usuario.Text == "")
            {
                MessageBox.Show("Introduzca los datos para continuar");

            }
            else
            {
                string agregar = "insert into Usuarios values('" + tb_usuario.Text + "','" + tb_pass.Text + "','" + cb_tipo.Text + "')";
                if (bd.executecommand(agregar))
                {
                    MessageBox.Show("Registro agregado correctamente");
                    Refresh();
                }
               
            }
           


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button1.Enabled = false;
            button3.Enabled = false;
            cb_tipo.Enabled = false;

            if (tb_usuario.Text == "" || tb_pass.Text == "")
            {
                MessageBox.Show("Introduzca el usuario y la contraseña a modificar para continuar ");

            }
            else
            {
                string actualizar = "update Usuarios set Password=" + "'" + tb_pass.Text + "'" + "where Usuario=" + "'" + tb_usuario.Text + "'";
                if (bd.executecommand(actualizar))
                {
                    MessageBox.Show("Registro actualizado correctamente");
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Error al modificar");
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            tb_pass.Enabled = false;
            cb_tipo.Enabled = false;

            if (tb_usuario.Text == "")
            {
                MessageBox.Show("Introduzca un ID para continuar");
            }
            else
            {
                if (MessageBox.Show("Desea continuar?", "Open pain", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string eliminar = "delete Usuarios where Usuario=" + "'" + tb_usuario.Text + "'";
                    if (bd.executecommand(eliminar))
                    {
                        MessageBox.Show("Registro eliminado correctamente");
                        Refresh();
                    }
                }
                else
                {
                    Refresh();
                }
                

             

            }
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Login ModForm = new Login();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    

        //VALIDACIONES
        public void Refresh()
        {
            panel1.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            cb_tipo.Enabled = true;
            tb_pass.Enabled = true;
            tb_usuario.Text = "";
            tb_pass.Text = "";
            cb_tipo.Text = "";
            dgv_usuarios.DataSource = bd.SelectDataTable("select * from usuarios");
        }

    }
}
