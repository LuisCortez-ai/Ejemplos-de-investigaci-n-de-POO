using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    public class Telefono
    {
        public string Modelo;
        public int Año, sonar;
        public void SmartphoneNuevo()
        {
            Console.WriteLine("\n\tEl modelo del smartphone es " + Modelo + " del año " + Año);
        }
        public void Mejoras()
        {
            if (sonar==1)
            {
                Console.WriteLine("\tEl smartphone esta sonando");
            }
            else
                Console.WriteLine("\tEl smartphone no esta sonando");
        }
    }
    public class Program
    {
        public static void Main()
        {
            //Creación de instancia de Objeto
            Telefono smartphone1 = new Telefono();
            //Asignación de valores
            smartphone1.Modelo = "Samsung Note 8";
            smartphone1.Año = 2025;
            smartphone1.sonar = 1;
            //Creación de instancia de Objeto
            Telefono smartphone2 = new Telefono();
            //Asignación de valores
            smartphone2.Modelo = "Xiaomi Remdmi 12";
            smartphone2.Año = 2025;
            smartphone2.sonar = 0;
            //Llamada de métodos
            smartphone1.SmartphoneNuevo();
            smartphone1.Mejoras();
            smartphone2.SmartphoneNuevo();
            smartphone2.Mejoras();

        }
    }
  }

