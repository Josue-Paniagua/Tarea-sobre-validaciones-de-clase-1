using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.piloto
{
    internal class Ipiloto
    {
        string Nombre { get; set; }
        int edad { get; set; }

        string Tipolicencia { get; set; }



        public Ipiloto(string name, int edadPiloto, string tipo)
        {
            this.Nombre = name;
            this.edad = edadPiloto;
            this.Tipolicencia = tipo;
        }
    }
}

