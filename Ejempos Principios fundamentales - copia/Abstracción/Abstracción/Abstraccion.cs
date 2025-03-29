using System;

public abstract class Dispositivo
{
    protected bool encendido = false; // Guarda el estado del dispositivo

    public void Encender()
    {
        if (!encendido)
        {
            encendido = true;
            Console.WriteLine($"{GetType().Name} encendido.");
        }
        else
        {
            Console.WriteLine($"{GetType().Name} ya estaba encendido.");
        }
    }

    public void Apagar()
    {
        if (encendido)
        {
            encendido = false;
            Console.WriteLine($"{GetType().Name} apagado.");
        }
        else
        {
            Console.WriteLine($"{GetType().Name} ya estaba apagado.");
        }
    }

    public bool EstaEncendido()
    {
        return encendido;
    }
}

public class Lampara : Dispositivo { }
public class Televisor : Dispositivo { }

class Abstraccion
{
    static void Main()
    {
        Lampara miLampara = new Lampara();
        Televisor miTelevisor = new Televisor();

        while (true)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Encender Lámpara");
            Console.WriteLine("2. Apagar Lámpara");
            Console.WriteLine("3. Encender Televisor");
            Console.WriteLine("4. Apagar Televisor");
            Console.WriteLine("5. Ver estado de los dispositivos");
            Console.WriteLine("6. Salir");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    miLampara.Encender();
                    break;
                case "2":
                    miLampara.Apagar();
                    break;
                case "3":
                    miTelevisor.Encender();
                    break;
                case "4":
                    miTelevisor.Apagar();
                    break;
                case "5":
                    Console.WriteLine($"\nEstado actual:");
                    Console.WriteLine($"Lámpara: {(miLampara.EstaEncendido() ? "Encendida" : "Apagada")}");
                    Console.WriteLine($"Televisor: {(miTelevisor.EstaEncendido() ? "Encendido" : "Apagado")}");
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
