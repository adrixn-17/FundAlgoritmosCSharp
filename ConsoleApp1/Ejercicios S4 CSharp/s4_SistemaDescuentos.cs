Console.Write("Tipo de cliente (1=VIP, 2=Regular): ");
int tipo = int.Parse(Console.ReadLine());
Console.Write("Monto de compra (S/): ");
double monto = double.Parse(Console.ReadLine());

double descuento = 0;

if (tipo == 1)
{
    if (monto > 100)
        descuento = monto * 0.20;
    else
        descuento = monto * 0.10;
}
else
{
    if (monto > 200)
        descuento = monto * 0.10;
    else
        descuento = monto * 0.05;
}

double total = monto - descuento;
Console.WriteLine("Descuento aplicado: S/ " + descuento);
Console.WriteLine("Monto final a pagar: S/ " + total);