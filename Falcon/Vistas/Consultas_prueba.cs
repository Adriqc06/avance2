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
    public partial class Consultas_prueba : Form
    {
        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-SOIGO22;Initial Catalog=Falcon;Integrated Security=True");
        public Consultas_prueba()
        {
            InitializeComponent();
        }
        //BaseDeDatos bd = new BaseDeDatos();
        private void Consultas_prueba_Load(object sender, EventArgs e)
        {
          
        }
        void buscar()
        {
            //SqlDataAdapter da = new SqlDataAdapter("buscar", cm);
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //da.SelectCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = dt_desde.Text;
            //da.SelectCommand.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = dt_hasta.Text;
            //DataTable dt = new DataTable();
            //this.dgv_consultas.DataSource = dt;
            //da.Fill(dt);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pruebas ModForm = new Pruebas();
            this.Hide();
            ModForm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_tipoprueba.Text == "")
            {
                MessageBox.Show("Seleccione un tipo de prueba");
            }
            string query = "Select * from Prueba where TipoPrueba= '"+cb_tipoprueba.Text+"'"+ " and Fecha >='" + dt_desde.Text+"'"+" and Fecha <='"+dt_hasta.Text+"'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv_consultas.DataSource = tabla;

           
        }



        private void ExportarDatos(DataGridView datalistado)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in datalistado.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in datalistado.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                    }
                }
                excel.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Registros a Exportar.");
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgv_consultas);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dgv_consultas.Rows)
            {
                total += Convert.ToInt32(row.Cells["Cantidad"].Value);
            }
            tb_cantidad.Text = Convert.ToString(total);
        }
    }
}
