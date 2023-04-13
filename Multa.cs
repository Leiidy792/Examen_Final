using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola
{
    public class Multa
    {
        public Conductor Conductor { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Agente Agente { get; set; }
        public double ValorMulta { get; set; }
        public DateTime FechaMulta { get; set; }

        public Multa(Conductor conductor, Vehiculo vehiculo, Agente agente, double valorMulta)
        {
            Conductor = conductor;
            Vehiculo = vehiculo;
            Agente = agente;
            ValorMulta = valorMulta;
            FechaMulta = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Fecha: {FechaMulta.ToString("dd/MM/yyyy HH:mm:ss")}\n{Conductor.ToString()}\n{Vehiculo.ToString()}\n{Agente.ToString()}\nValor de la multa: RD$ {ValorMulta.ToString("#,0.00")}";
        }
    }
}
