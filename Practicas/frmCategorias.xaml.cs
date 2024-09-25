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

namespace POO_Practica2.Practicas
{
    public partial class frmCategorias : Window
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void miBuscar_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM categories WHERE CategoryId = @CategoryId";
            using (SqlConnection conn = new SqlConnection("Data Source=WILVER\\SQLEXPRESS;Initial Catalog=NORTHWIND;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoryId", txtID.Text);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Asignar valores a las propiedades de la clase
                    this.txtnombre.Text = reader["CategoryName"].ToString();
                    this.txtDescripcion.Text = reader["Description"].ToString();
                    //this.pbPicture. = (byte[])reader["Picture"];
                }
                else
                    MessageBox.Show("Registro no encontrado");
                reader.Close();
            }
        }
    }
}
