MostrarLinea('*', 10);
MostrarLinea('-', 20);

void MostrarLinea(char caracter, int n)
{
    string linea = "";
    for (int i = 1; i <= n; i++)
    {
        linea = linea + caracter;
    }
    Console.WriteLine(linea);
}