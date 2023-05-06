using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.MisInterfaces
{
    internal class ClsPersona : IPersona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public ClsPersona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void CumpliAños()
        {
            Edad++;
            Console.WriteLine($"¡Hoy es mi cumpleaños! Ahora tengo {Edad} años.");
        }

        public void DecirNombre()
        {
            Console.WriteLine($"Mi nombre es {Nombre}");
        }

        public void Saludar()
        {
            Console.WriteLine("¡Hola!");
        }
    }
}
