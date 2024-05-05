using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Chocolate { get; set; }
        public string Tipo { get; set; }
        public string ColorFavorito { get; set; }
        public string NumeroFavorito { get; set; }

        //metodos

        public string Saludar()
        {
            
            string mensaje= "Nombre: " + Nombre + "\n" + "Fecha: " + FechaNacimiento + "\n" + "Chocolate: " + Chocolate + "\n" + "tipo: " + Tipo + "\n" + "color favorito: " + ColorFavorito + "\n" + "numero favorito: " + NumeroFavorito;
            return mensaje;
            
        }
    }
}
