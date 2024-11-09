using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Clase01
{
    internal class Alumno
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; } // > 32bit => Long
        public string DNI { get; set; }

        // public Alumno() { }
    }
}
