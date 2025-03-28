using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    public class DetalleAutoRentado
    {
        public string Modelo;
        public int Año;
        public double Gasolina, Kilometraje;

        public void ModeloyAño()
        {
            Console.WriteLine("\n\tEl modelo del auto es " + Modelo + " del año " + Año);
        }
        public void KilometrajeYGas()
        {
            Console.WriteLine("\tEl kilometraje recorrido es " + Kilometraje + " km y cantidad de gasolina es " + Gasolina + " litros");
        }
    }
    public class Program
    {
        public static void Main()
        {
            //Creación de instancia de Objeto
            DetalleAutoRentado Auto1 = new DetalleAutoRentado();
            //Asignación de valores
            Auto1.Modelo = "Toyota Corolla";
            Auto1.Año = 2017;
            Auto1.Kilometraje = 63000;
            Auto1.Gasolina = 8.5;
            //Creación de instancia de Objeto
            DetalleAutoRentado Auto2 = new DetalleAutoRentado();
            //Asignación de valores
            Auto2.Modelo = "Mitsubishi Lancer";
            Auto2.Año = 2021;
            Auto2.Kilometraje = 36000;
            Auto2.Gasolina = 9.5;
            //Llamada de métodos
            Auto1.ModeloyAño();
            Auto1.KilometrajeYGas();
            Auto2.ModeloyAño();
            Auto2.KilometrajeYGas();


        }
    }
}
