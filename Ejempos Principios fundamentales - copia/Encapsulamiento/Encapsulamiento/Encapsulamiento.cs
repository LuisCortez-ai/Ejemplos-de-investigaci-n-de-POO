using System;
using System.Collections.Generic;

public class DiarioPersonal
{
    private List<string> entradas = new List<string>(); // Lista para almacenar múltiples entradas

    // Método para escribir en el diario
    public void Escribir(string texto)
    {
        entradas.Add(texto);
        Console.WriteLine("Entrada guardada.");
    }

    // Método para leer la última entrada
    public string LeerUltima()
    {
        if (entradas.Count == 0)
            return "No hay nada escrito aún.";

        return entradas[entradas.Count - 1]; // Devuelve la última entrada agregada
    }

  
    public void LeerTodas()
    {
        if (entradas.Count == 0)
        {
            Console.WriteLine("No hay entradas en el diario.");
            return;
        }

        Console.WriteLine("📖 Entradas del diario:");
        for (int i = 0; i < entradas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {entradas[i]}");
        }
    }
}

