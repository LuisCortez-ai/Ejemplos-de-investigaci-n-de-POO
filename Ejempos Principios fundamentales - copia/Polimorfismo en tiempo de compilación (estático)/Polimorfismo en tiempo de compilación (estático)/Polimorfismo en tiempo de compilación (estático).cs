using System;

public class Linterna
{
    private bool encendida = false;
    private string modoActual = "normal";

    public void Encender()
    {
        if (!encendida)
        {
            encendida = true;
            Console.WriteLine($"Luz {modoActual} encendida.");
        }
        else
        {
            Console.WriteLine($"La linterna ya está encendida en modo {modoActual}.");
        }
    }

    public void Encender(string modo)
    {
        if (!encendida || modoActual != modo)
        {
            encendida = true;
            modoActual = modo;
            Console.WriteLine($"Luz {modo} encendida.");
        }
        else
        {
            Console.WriteLine($"La linterna ya está encendida en modo {modo}.");
        }
    }

    public void Apagar()
    {
        if (encendida)
        {
            encendida = false;
            Console.WriteLine("Linterna apagada.");
        }
        else
        {
            Console.WriteLine("La linterna ya está apagada.");
        }
    }

    public void Estado()
    {
        Console.WriteLine(encendida ? $"La linterna está encendida en modo {modoActual}." : "La linterna está apagada.");
    }
}

class Program
{
    static void Main()
    {
        Linterna miLinterna = new Linterna();

        while (true)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Encender luz normal");
            Console.WriteLine("2. Encender luz roja");
            Console.WriteLine("3. Encender luz intermitente");
            Console.WriteLine("4. Apagar linterna");
            Console.WriteLine("5. Ver estado de la linterna");
            Console.WriteLine("6. Salir");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    miLinterna.Encender();
                    break;
                case "2":
                    miLinterna.Encender("roja");
                    break;
                case "3":
                    miLinterna.Encender("intermitente");
                    break;
                case "4":
                    miLinterna.Apagar();
                    break;
                case "5":
                    miLinterna.Estado();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
