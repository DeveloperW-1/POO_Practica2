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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace POO_Practica2.Practicas
{
    public partial class frmCategorias : Window
    {
        public frmCategorias()
        {
            InitializeComponent();
            cargarFolio();
        }

        void cargarFolio()
        {
            string query = "SELECT MAX(categoryid)+1 AS Folio FROM categories";
            using (SqlConnection conn = new SqlConnection("Data Source=WILVER\\SQLEXPRESS;Initial Catalog=NORTHWIND;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Asignar valores a las propiedades de la clase
                    this.txtID.Text = reader["folio"].ToString();
                }
                reader.Close();
            }
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

        private void miAgregar_Click(object sender, RoutedEventArgs e)
        {
            string query = "SELECT * FROM categories WHERE CategoryId = @CategoryId";
            string querysave = "INSERT INTO categories (categoryname, description) VALUES (@CategoryName, @Description)";
            string queryupdate = "UPDATE categories SET categoryname = @CategoryName, description = @Description WHERE CategoryID = @CategoryId";
            using (SqlConnection conn = new SqlConnection("Data Source=WILVER\\SQLEXPRESS;Initial Catalog=NORTHWIND;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoryID", txtID.Text);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Modificar
                    SqlCommand cmdupdate = new SqlCommand(queryupdate, conn);
                    cmdupdate.Parameters.AddWithValue("@CategoryId", txtID.Text);
                    cmdupdate.Parameters.AddWithValue("@CategoryName", txtnombre.Text);
                    cmdupdate.Parameters.AddWithValue("@Description", txtDescripcion.Text);

                    reader.Close();

                    cmdupdate.ExecuteNonQuery();
                }
                else
                {
                    // Grabar
                    SqlCommand cmdsave = new SqlCommand(querysave, conn);
                    cmdsave.Parameters.AddWithValue("@CategoryName", txtnombre.Text);
                    cmdsave.Parameters.AddWithValue("@Description", txtDescripcion.Text);
                    
                    reader.Close();
                    
                    cmdsave.ExecuteNonQuery();

                    MessageBox.Show("Registro Guardado exitosamente");

                    txtDescripcion.Clear();
                    txtnombre.Clear();

                    txtnombre.Focus();

                    cargarFolio();

                }
                reader.Close();
            }
        }

        private void miBorrar_Click(object sender, RoutedEventArgs e)
        {
            string queryCheck = "SELECT COUNT(*) FROM categories WHERE CategoryId = @CategoryId";
            string queryDelete = "DELETE FROM categories WHERE CategoryId = @CategoryId";

            using (SqlConnection conn = new SqlConnection("Data Source=WILVER\\SQLEXPRESS;Initial Catalog=NORTHWIND;Integrated Security=True"))
            {
                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@CategoryId", txtID.Text);

                conn.Open();

                // Ejecutar consulta para verificar si el ID existe
                int count = (int)cmdCheck.ExecuteScalar();

                if (count > 0)
                {
                    // Si existe, preguntar al usuario si quiere eliminarlo
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        SqlCommand cmdDelete = new SqlCommand(queryDelete, conn);
                        cmdDelete.Parameters.AddWithValue("@CategoryId", txtID.Text);

                        // Ejecutar la eliminación
                        int rowsAffected = cmdDelete.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Categoría eliminada exitosamente.");
                            cargarFolio(); // Recargar el nuevo folio después de eliminar
                            txtnombre.Clear();
                            txtDescripcion.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la categoría.");
                        }
                    }
                }
                else
                {
                    // Si no existe, mostrar mensaje
                    MessageBox.Show("No se encontró una categoría con ese ID.");
                }
            }
        }


    }
}
