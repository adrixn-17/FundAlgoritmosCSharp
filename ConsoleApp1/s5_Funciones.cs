// Declarar variables
double radio = 0;
double _base = 0;
double altura = 0;
double resultado = 0;

// --- PROCESO PARA EL CÍRCULO ---
// Obtener los valores de entrada del usuario
Console.WriteLine("Ingrese el radio del circulo: ");
radio = double.Parse(Console.ReadLine());

// Realizar el proceso (llamar a la funcion)
resultado = AreaCirculo(radio);

// Mostrar el valor de lo procesado
Console.WriteLine("El valor del area del circulo es: " + resultado);

// --- PROCESO PARA EL TRIÁNGULO ---
// Calcular el area del triangulo
Console.WriteLine("Ingrese la base del triangulo: ");
_base = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo: ");
altura = double.Parse(Console.ReadLine());

// Invocar (llamar a la funcion)
resultado = AreaTriangulo(_base, altura);

// Mostrar el resultado al usuario
Console.WriteLine("El area del triangulo es: " + resultado);


// --- DEFINICIÓN DE FUNCIONES ---

// Declarar funcion AreaCirculo
// tipo nombre_func(tipo dato param variable parm)
double AreaCirculo(double radio)
{
    // Declarar variables
    double resultado = 0;
    // Proceso
    resultado = Math.PI * Math.Pow(radio, 2);
    // Retorna el resultado
    return resultado; // No olvidar
}

// Declarar la funcion AreaTriangulo
double AreaTriangulo(double _base, double altura)
{
    //Declarar variables
    double resultado = 0;
    // Proceso
    resultado = (_base * altura) / 2;
    // retornar el valor
    return resultado;
}