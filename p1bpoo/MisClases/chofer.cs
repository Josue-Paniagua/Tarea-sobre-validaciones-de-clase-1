using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.piloto;

namespace p1bpoo.MisClases
{
    internal class chofer : Ipiloto
    {
        public string Nombre { get; set; }
        public int edad { get; set; }
        public string Tipolicencia { get; set; }

        public chofer(string name, int edadPiloto, string tipo) : base(name, edadPiloto, tipo)
        {
            Nombre = name;
            edad = edadPiloto;
            Tipolicencia = tipo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: {0}", this.Nombre);
            Console.WriteLine("Edad: {0}", this.edad);
            Console.WriteLine("Licencia tipo: {0}", this.Tipolicencia);
        }

        public void ValidadEdadLicencia()
        {
            if (Tipolicencia == "A")
            {
                if (edad < 24)
                {
                    Console.WriteLine("EL piloto no tiene la edad minima para poder manejar un vehiculo que requiera licencia de tipo A");
                }
                else
                {
                    Console.WriteLine("El piloto cumple con los requisitos para manejar un vehiculo que requiera licencia de tipo A");
                }
            }
            else if (Tipolicencia == "B")
            {
                if (edad < 21)
                {
                    Console.WriteLine("EL piloto no tiene la edad minima para poder manejar un vehiculo que requiera licencia de tipo B");
                }
                else
                {
                    Console.WriteLine("El piloto cumple con los requisitos para manejar un vehiculo que requiera licencia de tipo B");
                }
            }
            else if (Tipolicencia == "C")
            {
                if (edad < 21)
                {
                    Console.WriteLine("EL piloto no tiene la edad minima para poder manejar vehiculos que requieran licencia de tipo C");
                }
                else
                {
                    Console.WriteLine("El piloto cumple con los requisitos para manejar un vehiculo que requiera licencia de tipo C");
                }
            }
        }
    }
}
