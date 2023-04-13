using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola
{
    
        public class Conductor
        {
            public string NombreCompleto { get; set; }
            public string Cedula { get; set; }
            public string Direccion { get; set; }
            public string TipoLicencia { get; set; }
            public DateTime FechaNacimiento { get; set; }

            public void RegistrarConductor()
            {
            Conductor conductors = new Conductor();
            List<Conductor> conductores = new List<Conductor>();
            Console.Write("Nombre completo: ");
                NombreCompleto = Console.ReadLine();

                Console.Write("Cédula: ");
                Cedula = Console.ReadLine();

                Console.Write("Dirección: ");
                Direccion = Console.ReadLine();

                Console.Write("Tipo de licencia (A, B, C): ");
                TipoLicencia = Console.ReadLine();

                Console.Write("Fecha de nacimiento (dd/mm/aaaa): ");
                FechaNacimiento = DateTime.Parse(Console.ReadLine());
            }
        }
    
}
