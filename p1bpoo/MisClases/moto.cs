using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class moto : Vehiculo
    {
        // Constructor
        public moto(int anio, string elColor, string elModelo)
            : base(anio, elColor, elModelo, velocidadMaxima : 120, 100, 10) // Asignamos la velocidad máxima
        {
            CapacidadTanque = 15; // 15 galones
            ConsumoCombustible = 1; // 1 galón por km
        }

        private int estadovehiiculo = 2;
        protected new int CapacidadTanque { get; set; } = 15;
        protected new int ConsumoCombustible { get; set; } = 1;
        protected new int VelocidadMaxima { get; set; } = 120;

        // Método específico para la moto
        public void HacerCaballito()
        {
            if (estadovehiiculo == 2) 
            {
                Console.WriteLine(" Haciendo un caballito");
            }
            else
            {
                Console.WriteLine("No puedes hacer un caballito si la moto está detenida.");
            }
        }

        // Método para mostrar información de la moto
        public void InformacionMoto()
        {
            InformacionVehiculo(); // Llama al método de la clase base
            Console.WriteLine("Capacidad del Tanque: {0} galones", CapacidadTanque);
            Console.WriteLine("Consumo de Combustible: {0} galones/km", ConsumoCombustible);
        }
    }
}








