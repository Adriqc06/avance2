using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Falcon.Controlador;
using Falcon.Modelo;


namespace Falcon
{
    public partial class Consultas_paquetería : Form
    {
        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-SOIGO22;Initial Catalog=Falcon;Integrated Security=True");

        public Consultas_paquetería()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Consultas_prueba ModForm = new Consultas_prueba();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Paqueteria ModForm = new Paqueteria();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (cb_tipoprueba.Text == "")
            {
                MessageBox.Show("Seleccione un tipo de prueba");
            }*/
            string query = "Select * from Paqueteria where  Fecha >='" + desde.Text + "'" + " and Fecha <='" + hasta.Text + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv_consultas2.DataSource = tabla;
        }
   

        private void button3_Click(object sender, EventArgs e)
        {
            Patrones_UX cosa = new Patrones_UX();
            cosa.ExportarDatos(dgv_consultas2);
        }

        private void Consultas_paquetería_Load(object sender, EventArgs e)
        {

        }
    }
}
//TipoPrueba= '" + cb_tipoprueba.Text + "'" + " and