Console.Write("¿Cuántos números quieres sumar? ");
int n = int.Parse(Console.ReadLine());

int suma = 0, mayor = 0, menor = 0, i = 1;

while (i <= n)
{
    Console.Write("Ingrese número " + i + ": ");
    int num = int.Parse(Console.ReadLine());
    suma += num;
    if (i == 1) { mayor = num; menor = num; }
    else
    {
        if (num > mayor) mayor = num;
        if (num < menor) menor = num;
    }
    i++;
}

double promedio = (double)suma / n;
Console.WriteLine("Cantidad: " + n);
Console.WriteLine("Suma total: " + suma);
Console.WriteLine("Promedio: " + promedio);
Console.WriteLine("Mayor: " + mayor);
Console.WriteLine("Menor: " + menor);