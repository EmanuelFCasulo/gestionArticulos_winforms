using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        //TODO: CATEGORIA
        public Categoria() { }
        public Categoria(string str) 
        {
            categoria = str;
        }
        public string categoria { get; set; }
        public int idCategoria { get; set; }
        //Sobreescritura de metodo toString para que solo devuelva la categoria cuando hagamos la lectura del objeto categoria
        public override string ToString()
        { 
            return categoria;
        }
    }
}
