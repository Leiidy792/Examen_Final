using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hola
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string NumeroChasis { get; set; }
        
        void RegistrarVehiculo()
        {
            Vehiculo vehiculo = new Vehiculo();
            List<Vehiculo> Vehiculos = new List<Vehiculo>();
            Console.WriteLine("Por favor ingrese los datos del vehículo:");
            Console.Write("Placa: ");
            vehiculo.Placa = Console.ReadLine();

            Console.Write("Marca: ");
            vehiculo.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            vehiculo.Modelo = Console.ReadLine();

            Console.Write("Color: ");
            vehiculo.Color = Console.ReadLine();

            Console.Write("Número de chasis: ");
            vehiculo.NumeroChasis = Console.ReadLine();
            Vehiculos.Add(vehiculo);
        }

    }
    
 }

