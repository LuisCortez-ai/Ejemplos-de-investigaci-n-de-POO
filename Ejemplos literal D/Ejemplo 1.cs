using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1
{
    public class CuentadeBitcoin
    {
        private double Saldo;
        public void Retirar(double cantidad)
        {
            if (Saldo >= cantidad)
            {
                Saldo -= cantidad;
                Console.WriteLine($"\tRetiro exitoso. Nuevo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("\tNo hay suficientes fondos para retirar");
            } 
                
        }
        public class Program
        {
            static void Main(string[] args)
            {
                CuentadeBitcoin Cuenta1 = new CuentadeBitcoin();
                Cuenta1.Saldo = 0;
                CuentadeBitcoin Cuenta2 = new CuentadeBitcoin();
                Cuenta2.Saldo = 170.3;
                CuentadeBitcoin Cuenta3 = new CuentadeBitcoin();
                Cuenta3.Saldo = 245.5;
                //Impriendo detalles
                Cuenta1.Retirar(50.0);
                Cuenta2.Retirar(50.0);
                Cuenta3.Retirar(50.0);

            }
        }
    }
}
