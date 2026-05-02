int total = 0, mayor = -1, menor = 21;
int excelente = 0, bueno = 0, aprobado = 0, desaprobado = 0;
double suma = 0;
int nota;

do
{
    Console.Write("Ingrese nota (0-20) o -1 para salir: ");
    nota = int.Parse(Console.ReadLine());

    if (nota != -1)
    {
        if (nota >= 0 && nota <= 20)
        {
            total++;
            suma += nota;
            if (nota > mayor) mayor = nota;
            if (nota < menor) menor = nota;
            if      (nota >= 17) excelente++;
            else if (nota >= 14) bueno++;
            else if (nota >= 11) aprobado++;
            else                 desaprobado++;
        }
        else
            Console.WriteLine("Nota inválida. Ingresa entre 0 y 20.");
    }
} while (nota != -1);

if (total > 0)
{
    Console.WriteLine("Total de notas: " + total);
    Console.WriteLine("Promedio: " + (suma / total));
    Console.WriteLine("Nota más alta: " + mayor);
    Console.WriteLine("Nota más baja: " + menor);
    Console.WriteLine("Excelente (17-20): " + excelente);
    Console.WriteLine("Bueno (14-16): " + bueno);
    Console.WriteLine("Aprobado (11-13): " + aprobado);
    Console.WriteLine("Desaprobado (0-10): " + desaprobado);
}
else
    Console.WriteLine("No se ingresó ninguna nota.");