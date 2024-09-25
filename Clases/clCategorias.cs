using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Practica2.Clases
{
    class clCategorias
    {

        private int CategoryID;
        private string CategoryName;
        private string Description;
        private byte Picture;

        public clCategorias()
        {
            // Mostrar todos los datos de la tabla
        }
        // Metodo para buscar por ID
        public clCategorias(int CategoryID)
        {
            this.CategoryID = CategoryID;


        }
        public clCategorias(int categoryID, string categoryName, string description, byte picture)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            Description = description;
            Picture = picture;
        }
        //PROCEDIMIENTOS
        // Buscar Individualmente
        public string buscarIndividualmente()
        {
            return ($"SELECT * FROM Categories WHERE CategoryID = {this.CategoryID}");
        }
        // Buscar Todos
        // Modificar
        // Eliminar
    }
}
