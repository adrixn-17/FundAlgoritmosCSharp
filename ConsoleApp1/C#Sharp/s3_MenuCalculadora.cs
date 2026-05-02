Console.WriteLine("##### Menu Calculadora #####");
Console.WriteLine("Menu Operaciones");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicación");
Console.WriteLine("4. División");
Console.WriteLine("");
Console.Write("Ingresa primer número: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Ingresa segundo número: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Ingresa opción: ");
int opc = int.Parse(Console.ReadLine());
double resultado = 0;
switch (opc)
{
    case 1:
        resultado = a + b;
        break;
    case 2:
        resultado = a - b;
        break;
    case 3:
        resultado = a * b;
        break;
    case 4:
        resultado = a / b;
        break;
    default:
        Console.Write("Opción no existe");
        break;
}
Console.WriteLine("Resultado: " + resultado);