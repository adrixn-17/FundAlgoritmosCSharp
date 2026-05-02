int cont = 100; // Variable local
cont++;
Contar();
Contar();
Contar();
Console.WriteLine("Var Main: " + cont);

void Contar()
{
    int cont = 0; // Variable local
    cont++;
    Console.WriteLine("Var Func: " + cont);
}