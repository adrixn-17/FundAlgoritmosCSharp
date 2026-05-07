int cont = 100; // variable local del main
cont++;
Contar();
Contar();
Contar();
Console.WriteLine("Var Main: " + cont);

void Contar()
{
    int cont = 0; // Variable local de la funcion
    cont++; // suma 1 a la varible local
    Console.WriteLine("Var Func: " + cont);
}