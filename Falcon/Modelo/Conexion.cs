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
using Falcon.Vistas;
using Falcon.Controlador;

namespace Falcon.Modelo
{
   public class Conexion
    {

        public SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-SOIGO22;Initial Catalog=Falcon;Integrated Security=True");

        

    }
}
