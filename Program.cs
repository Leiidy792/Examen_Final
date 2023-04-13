using Hola;
using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace GestionMultas
{
    class Program
    {
        public static double valorMulta { get; private set; }


        static void Main(string[] args)
        {

            Console.WriteLine("Por favor ingrese los datos del agente de tránsito:");
            Hola.Agente agente = new Hola.Agente();

            Console.WriteLine("Por favor seleccione el tipo de infracción:");
            Console.WriteLine("1 - Obstrucción de tránsito (RD$ 1800.00)");
            Console.WriteLine("2 - Pase de semáforo en rojo (RD$ 5,950.00)");
            Console.WriteLine("3 - Hablar por el celular (RD$ 3,750.00)");
            Console.WriteLine("4 - Conducir sin cinturón (RD$ 2,560.00)");
            Console.WriteLine("5 - Licencia vencida (RD$ 3,890.00)");
            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    valorMulta = 1800.00;
                    break;
                case 2:
                    valorMulta = 5950.00;
                    break;
                case 3:
                    valorMulta = 3750.00;
                    break;
                case 4:
                    valorMulta = 2560.00;
                    break;
                case 5:
                    valorMulta = 3890.00;
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    return;
            }

            Multa multa = new Multa(conductor,vehiculo, agente, valorMulta);
            Console.WriteLine("Multa registrada con éxito");

            string filePath = "multas.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(multa.ToString());
            }
        }

    }
}

