using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    //Creamos la clase padre
    public class CuentadeBitcoin
        //Defomos sus propiedades y métodos
    {
        protected double Saldo;
        public CuentadeBitcoin(double SaldoInicial)
        {
            Saldo = SaldoInicial;
        }
        public void Retirar(double cantidad)
        {
            if (Saldo >= cantidad)
            {
                Saldo -= cantidad;
                Console.WriteLine($"\n\tRetiro exitoso. Nuevo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("\tNo hay suficientes fondos para retirar");
            } 
                
        }
        //Creamos la clase heredada
        public class CuentaPremium : CuentadeBitcoin
        {
        //Definimos las propiedades y métodos
            private double porcentajecashback = 0.05;
            public CuentaPremium(double SaldoInicial) : base(SaldoInicial)
            { }
            public new void Retirar(double cantidad)
            {
                if (Saldo >= cantidad)
                {
                    //Llamamos a la clase padre
                    base.Retirar(cantidad);
                    double cashback=cantidad*porcentajecashback;
                    Saldo += cashback;
                    Console.WriteLine($"\tRetiro con cashback. Nuevo saldo {Saldo} (Cashback: {cashback})");
                }
                else
                {
                    Console.WriteLine("\tNo hay suficientes fondos para retirar");
                }
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                //Creamos las instancias de los objetos
                CuentadeBitcoin Cuenta1 = new CuentadeBitcoin(0);
                CuentaPremium Cuenta2 = new CuentaPremium(170.3);
                //Impriendo detalles
                Cuenta1.Retirar(50.0);
                Cuenta2.Retirar(50.0);
            }
        }
    }
}
