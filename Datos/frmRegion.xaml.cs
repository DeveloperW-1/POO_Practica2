using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POO_Practica2.Datos
{
    /// <summary>
    /// Lógica de interacción para frmRegion.xaml
    /// </summary>
    public partial class frmRegion : Window
    {
        public frmRegion()
        {
            InitializeComponent();
        }

        private void miBuscar_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM region WHERE regionid = @RegionID";
            using (SqlConnection conn = new SqlConnection(Clases.clGlobales.globales.miconexion))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RegionID", txtID.Text);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Asignar valores a las propiedades de la clase
                    this.txtnombre.Text = reader["regionid"].ToString();
                    this.txtDescripcion.Text = reader["regiondescription"].ToString();
                    //this.pbPicture. = (byte[])reader["Picture"];
                }
                else
                    MessageBox.Show("Registro no encontrado");
                reader.Close();
            }
        }
    }
}
