using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;



namespace Falcon
{
    class Acceso_Chain_of_responsability
    {
        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-SOIGO22;Initial Catalog=Falcon;Integrated Security=True");

        public void logear(string usuario, string contraseña)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT Usuario, Tipo_usuario FROM Usuarios WHERE Usuario= @usuario AND Password = @pas",conexion);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt =new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count==1)
                {
                    //this.Hide();
                    if (dt.Rows[0][1].ToString()=="Paqueteria")
                    {
                        Paqueteria ModForm = new Paqueteria();
                        MessageBox.Show("Bienvenido!  "+usuario);
                       
                       // this.Hide();
                        ModForm.ShowDialog();
                        //this.Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Pruebas")
                    {
                        Pruebas ModForm = new Pruebas();
                        MessageBox.Show("Bienvenido!  "+usuario);
                        //this.Hide();
                        ModForm.ShowDialog();
                        //this.Show(Pruebas);
                    }
                    else if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        Modulo_usuarios ModForm = new Modulo_usuarios();
                        MessageBox.Show("Bienvenido!  "+usuario);
                        
                        ModForm.ShowDialog();
                        ////this.Show(Pruebas);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }

        }


    }
}
