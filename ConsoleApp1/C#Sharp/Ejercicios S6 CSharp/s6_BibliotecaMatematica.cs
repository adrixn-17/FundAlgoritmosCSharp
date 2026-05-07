// Pruebas
Console.WriteLine("¿8 es par? " + EsPar(8));
Console.WriteLine("Factorial de 5: " + Factorial(5));
Console.WriteLine("Mayor de 3, 7, 5: " + MaxDe3(3, 7, 5));
Console.WriteLine("25°C en Fahrenheit: " + ConvTemp(25));
Console.WriteLine("Area rectangulo 4x6: " + AreaRect(4, 6));


// --- DEFINICIÓN DE FUNCIONES ---

bool EsPar(int n)
{
    return n % 2 == 0;
}

int Factorial(int n)
{
    int r = 1;
    for (int i = 1; i <= n; i++)
    {
        r = r * i;
    }
    return r;
}

double MaxDe3(double a, double b, double c)
{
    if (a >= b && a >= c)
        return a;
    else if (b >= c)
        return b;
    else
        return c;
}

double ConvTemp(double c)
{
    return c * 9.0 / 5.0 + 32;
}

double AreaRect(double b, double h)
{
    return b * h;
}