class Program
{
    static void Main()
    {
        DiarioPersonal diario = new DiarioPersonal();
        int opcion;

        do
        {
            Console.WriteLine("\n📔 Diario Personal");
            Console.WriteLine("1. Escribir en el diario");
            Console.WriteLine("2. Leer última entrada");
            Console.WriteLine("3. Leer todas las entradas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("❌ Opción no válida. Intente de nuevo.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Escriba su entrada: ");
                    string texto = Console.ReadLine();
                    diario.Escribir(texto);
                    break;

                case 2:
                    Console.WriteLine("Última entrada: " + diario.LeerUltima());
                    break;

                case 3:
                    diario.LeerTodas();
                    break;

                case 4:
                    Console.WriteLine("📕 Cerrando el diario. ¡Hasta la próxima!");
                    break;

                default:
                    Console.WriteLine("❌ Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 4);
    }
}
