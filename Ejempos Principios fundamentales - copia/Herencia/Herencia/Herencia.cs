using System;

public class Instrumento
{
    public void Tocar()
    {
        Console.WriteLine("El instrumento suena.");
    }
}

public class Flauta : Instrumento
{
    public void Silbar()
    {
        Console.WriteLine("La flauta silba.");
    }
}

public class Guitarra : Instrumento
{
    public void Rasguear()
    {
        Console.WriteLine("La guitarra rasguea.");
    }
}

public class Piano : Instrumento
{
    public void PulsarTeclas()
    {
        Console.WriteLine("El piano toca notas.");
    }
}

class Herencia
{
    static void Main()
    {
        Instrumento instrumentoSeleccionado = null;

        while (true)
        {
            Console.WriteLine("\nSeleccione un instrumento:");
            Console.WriteLine("1. Flauta");
            Console.WriteLine("2. Guitarra");
            Console.WriteLine("3. Piano");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    instrumentoSeleccionado = new Flauta();
                    break;
                case "2":
                    instrumentoSeleccionado = new Guitarra();
                    break;
                case "3":
                    instrumentoSeleccionado = new Piano();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    continue;
            }

            instrumentoSeleccionado.Tocar();

            if (instrumentoSeleccionado is Flauta flauta) flauta.Silbar();
            else if (instrumentoSeleccionado is Guitarra guitarra) guitarra.Rasguear();
            else if (instrumentoSeleccionado is Piano piano) piano.PulsarTeclas();
        }
    }
}
