using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private int velocidad = 0;
        private int estadoVehiculo = 0;

        protected List<string> tiposLicenicaAcepatados = new List<string> { "A", "B", "C" };
        private chofer piloto = null;

        protected virtual int CapacidadTanque { get; set; }
        protected virtual int ConsumoCombustible { get; set; }
        protected virtual int VelocidadMaxima { get; set; }

        public Vehiculo(int anio, string elColor, string elModelo, int velocidadMaxima, int capacidadTanque, int consumoCombustible)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
            this.VelocidadMaxima = velocidadMaxima;
            this.CapacidadTanque = capacidadTanque;
            this.ConsumoCombustible = consumoCombustible;
           
        }

        public string AsignarPiloto(chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (!tiposLicenicaAcepatados.Contains(elPiloto.Tipolicencia))
            {
                return "El piloto no tiene la licencia adecuada a este carro";

            }
            if (piloto != null)
            {
                return "Este vehiculo ya tiene un piloto asignado";

            }
            piloto = elPiloto;
            return "Piloto asignado correctamente";

        }


        public string Encender()
        {
            if (piloto == null)
            {
                return "No se puede encender sin un piloto asignado ";
            }
            if (estadoVehiculo == 0)
            {
                estadoVehiculo = 1;
                return "LIsto! el vehiculo esta arrancado ";

            }
            return "El carro ya esta encendido";
        }
        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }


        public virtual void acelerar(int cuanto)
        {
            if (velocidad + cuanto > VelocidadMaxima)
            {
                Console.WriteLine("¡Alerta! No se puede superar la velocidad máxima de {0} km/h.", VelocidadMaxima);
            }
            else
            {
                velocidad += cuanto;
                Console.WriteLine("Velocidad actual: {0} km/h", velocidad);
            }
        }
        public void Frenar(int cuanto)
        {
            if (velocidad - cuanto <= 0)
            {
                velocidad = 0;
                estadoVehiculo = 1; 
                Console.WriteLine("El vehículo se ha detenido. Estado: encendido.");
            }
            else
            {
                velocidad -= cuanto;
                Console.WriteLine("Velocidad reducida a {0} km/h", velocidad);
            }
        }

        public void Apagar()
        {
            if (velocidad == 0)
            {
                estadoVehiculo = 0;
                Console.WriteLine("El vehículo ha sido apagado.");
            }
            else
            {
                Console.WriteLine("No se puede apagar el vehículo en movimiento.");
            }
        }



        public void InformacionVehiculo()
        {
            Console.WriteLine("========== Información del Vehículo ==========");
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
            Console.WriteLine("Velocidad Actual: {0} km/h", this.velocidad);
            Console.WriteLine("Velocidad Máxima: {0} km/h", this.VelocidadMaxima);
            Console.WriteLine("Estado del Vehículo: {0}",
                estadoVehiculo == 0 ? "Apagado" :
                estadoVehiculo == 1 ? "Encendido" : "En Movimiento");

            if (piloto != null)
            {
                Console.WriteLine("Piloto Asignado: {0}", piloto.Nombre);
            }
            else
            {
                Console.WriteLine("Piloto Asignado: Ninguno");
            }
            Console.WriteLine("=============================================");
        }
    }
}


