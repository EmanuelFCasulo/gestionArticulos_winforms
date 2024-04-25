using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class Articulo
    {
        public Articulo() 
        { 
            marca = new Marca();
            categoria = new Categoria();
        }
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Código")]//TODO: Cambiar nombre del encabezado de la columna
        public string codigo { get; set; }
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [DisplayName("Descripción")]
        public string descripicion{ get; set; }
        [DisplayName("Marca")]
        public Marca marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria categoria { get; set; }
        [DisplayName("Precio")]
        public decimal precio { get; set; }
        //TODO mirar si agregamos una lista de imagenes o lo tratamos como atributo individual.
        //Puede haber mas de 1 imagen para un articulo
        //public List<string> imagenes { get; set; }  
        [DisplayName("URL")] 
        public string UrlImagen { get; set; }
    }
}
