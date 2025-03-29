using System;

public abstract class Forma
{
    public abstract void CalcularArea();
}

public class Cuadrado : Forma
{
    private double lado;

    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    public override void CalcularArea()
    {
        double area = lado * lado;
        Console.WriteLine($"El área del cuadrado es: {area}");
    }
}

public class Circulo : Forma
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override void CalcularArea()
    {
        double area = Math.PI * radio * radio;
        Console.WriteLine($"El área del círculo es: {area}");
    }
}

public class Triangulo : Forma
{
    private double baseT, altura;

    public Triangulo(double baseT, double altura)
    {
        this.baseT = baseT;
        this.altura = altura;
    }

    public override void CalcularArea()
    {
        double area = (baseT * altura) / 2;
        Console.WriteLine($"El área del triángulo es: {area}");
    }
}

class Program
{
    static void Main()
    {
        while (true) // Bucle infinito para que el programa no se cierre
        {
            Console.WriteLine("\nElige una figura para calcular el área:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion)) // Validación de entrada
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa la longitud del lado del cuadrado: ");
                    if (double.TryParse(Console.ReadLine(), out double lado))
                    {
                        Forma cuadrado = new Cuadrado(lado);
                        cuadrado.CalcularArea();
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                    }
                    break;

                case 2:
                    Console.Write("Ingresa el radio del círculo: ");
                    if (double.TryParse(Console.ReadLine(), out double radio))
                    {
                        Forma circulo = new Circulo(radio);
                        circulo.CalcularArea();
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                    }
                    break;

                case 3:
                    Console.Write("Ingresa la base del triángulo: ");
                    if (double.TryParse(Console.ReadLine(), out double baseT))
                    {
                        Console.Write("Ingresa la altura del triángulo: ");
                        if (double.TryParse(Console.ReadLine(), out double altura))
                        {
                            Forma triangulo = new Triangulo(baseT, altura);
                            triangulo.CalcularArea();
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    return; // Termina el programa

                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        }
    }
}
