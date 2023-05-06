using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.MisInterfaces
{
    internal interface IPersona
    {
        string Nombre { get;}
        int Edad { get; }
        void Saludar();
        void DecirNombre();
        void CumpliAños();
    }
}
