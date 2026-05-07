double precio = 100.50;

Console.WriteLine("Precio original: " + precio);
precio = CalcularDescuento(precio);
Console.WriteLine("Precio con descuento: " + precio);

double CalcularDescuento(double _precio)
{
    if(_precio > 80)
    {
        _precio = _precio - (_precio * 0.10);
    }
    Console.WriteLine("Valor de precio (copia): " + _precio);
    return _precio;
}