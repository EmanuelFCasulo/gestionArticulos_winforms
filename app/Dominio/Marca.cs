using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        //TODO: MARCA
        public Marca() { }
        public Marca(string str) 
        {
            marca = str;
        }
        public string marca { get; set; }
        public int idMarca { get; set; }
        //Sobreescritura de metodo toString para que solo devuelva la marca cuando hagamos la lectura del objeto marca
        public override string ToString()
        {
            return marca;
        }
    }
}
