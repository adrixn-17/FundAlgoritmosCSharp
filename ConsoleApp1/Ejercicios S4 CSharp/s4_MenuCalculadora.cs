int opcion;
do
{
    Console.WriteLine("Calculadora");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");
    Console.WriteLine("5. Salir");
    Console.Write("Elige una opción: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion >= 1 && opcion <= 4)
    {
        Console.Write("Ingrese número A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Ingrese número B: ");
        double b = double.Parse(Console.ReadLine());
        double resultado = 0;

        switch (opcion)
        {
            case 1: resultado = a + b; break;
            case 2: resultado = a - b; break;
            case 3: resultado = a * b; break;
            case 4:
                if (b != 0) resultado = a / b;
                else { Console.WriteLine("Error: División por cero"); break; }
                break;
        }
        Console.WriteLine("Resultado: " + resultado);
    }
    else if (opcion == 5)
        Console.WriteLine("Adiós");
    else
        Console.WriteLine("Opción inválida. Intenta de nuevo.");

} while (opcion != 5);