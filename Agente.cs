using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola
{
    public class Agente
    {
        public int NumeroEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string FechaIngreso { get; set; }
        List<Agente> agentes = new List<Agente>();
        void RegistrarAgente()
        {
            Agente agente = new Agente();
            
            Console.WriteLine("Por favor ingrese sus datos:");
            Console.Write("Nombre Completo: ");
            agente.NombreCompleto = Console.ReadLine();

            Console.Write("Direccion: ");
            agente.Direccion = Console.ReadLine();

            Console.Write("Fecha de Ingreso: ");
            agente.FechaIngreso = Console.ReadLine();
            agentes.Add(agente);
        }

        void Mostrar()
        {
            foreach(var agente in agentes)
            {
                Console.WriteLine("Nombre:" + NombreCompleto, "Direccion:" + Direccion, "Fecha de Ingreso" + FechaIngreso);
            }
        }

    }

}
