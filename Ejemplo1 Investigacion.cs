using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    public class Individuo
    {
        public string Nombre;
        public int Edad, Peso;
        public double Altura;

        public void Presentarse()
        {
            Console.WriteLine("\n\tHola, mi nombre es " + Nombre + " y tengo " + Edad + " Años");
        }
        public void MencionarRasgosFisicos()
        {
            Console.WriteLine("\tMi peso es " + Peso + " kg y mi altura es " + Altura + " metros");
        }
    }
    public class Program
    {
        public static void Main()
        {
            //Creación de instancia de Objeto
            Individuo Individuo1 = new Individuo();
            //Asignación de valores
            Individuo1.Nombre = "Luis";
            Individuo1.Edad = 20;
            Individuo1.Peso = 82;
            Individuo1.Altura = 1.75;
            //Creación de instancia de Objeto
            Individuo Individuo2 = new Individuo();
            //Asignación de valores
            Individuo2.Nombre = "Sergio";
            Individuo2.Edad = 35;
            Individuo2.Peso = 78;
            Individuo2.Altura = 1.63;
            //Llamada de métodos
            Individuo1.Presentarse();
            Individuo1.MencionarRasgosFisicos();
            Individuo2.Presentarse();
            Individuo2.MencionarRasgosFisicos();
        }
    }
}
