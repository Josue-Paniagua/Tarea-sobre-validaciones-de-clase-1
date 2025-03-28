using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {
        private string gasolina;
        private int capacidadCarga;
        private int potencia;

        public Camion(int anio, string elColor, string elModelo, int VelocidadMaxima) : base(anio, elColor, elModelo)
        {
            this.gasolina = "Diesel";
            this.capacidadCarga = 0;
            this.potencia = 200;
        }
        protected override int VelocidadMaxima { get; set; } = 50;
        protected override int CapacidadTanque { get; set; } = 500;
        protected override int ConsumoCombustible { get; set; } = 10;
    }
}