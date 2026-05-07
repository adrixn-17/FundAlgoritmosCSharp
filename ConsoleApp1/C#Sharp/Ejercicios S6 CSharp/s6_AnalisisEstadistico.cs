// --- MAIN ---
Console.Write("¿Cuántas notas desea ingresar? ");
int n = int.Parse(Console.ReadLine());

double suma = 0;
double mayor = -1;
double menor = 21;
int aprobados = 0;

for (int i = 1; i <= n; i++)
{
    double nota = LeerNota("Ingrese nota " + i + ": ");
    suma = suma + nota;
    if (nota > mayor) mayor = nota;
    if (nota < menor) menor = nota;
    if (EsAprobado(nota)) aprobados++;
    Console.WriteLine("Clasificación: " + ClasificarNota(nota));
}

double prom = CalcularPromedio(suma, n);
MostrarEstadisticas(prom, mayor, menor, aprobados, n);


// --- DEFINICIÓN DE FUNCIONES ---

double LeerNota(string mensaje)
{
    double nota = -1;
    while (nota < 0 || nota > 20)
    {
        Console.Write(mensaje);
        nota = double.Parse(Console.ReadLine());
        if (nota < 0 || nota > 20)
            Console.WriteLine("Nota inválida. Ingrese entre 0 y 20.");
    }
    return nota;
}

bool EsAprobado(double nota)
{
    return nota >= 11;
}

string ClasificarNota(double nota)
{
    if (nota >= 18)
        return "Excelente";
    else if (nota >= 14)
        return "Bueno";
    else if (nota >= 11)
        return "Aprobado";
    else
        return "Desaprobado";
}

double CalcularPromedio(double suma, int n)
{
    return suma / n;
}

void MostrarEstadisticas(double prom, double mayor, double menor, int aprobados, int total)
{
    Console.WriteLine("====== ESTADÍSTICAS ======");
    Console.WriteLine("Promedio:    " + prom);
    Console.WriteLine("Mayor nota:  " + mayor);
    Console.WriteLine("Menor nota:  " + menor);
    Console.WriteLine("Aprobados:   " + aprobados + "/" + total);
    Console.WriteLine("==========================");
}