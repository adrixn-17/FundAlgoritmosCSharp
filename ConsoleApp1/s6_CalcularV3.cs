// Declarar variables
double peso = 0;
double altura = 0;
double imc = 0;

// --- PROCESO PARA EL IMC ---
// Obtener los valores de entrada del usuario
Console.Write("Ingrese su peso (Kg): ");
peso = double.Parse(Console.ReadLine());

Console.Write("Ingrese su altura (m): ");
altura = double.Parse(Console.ReadLine());

// Invocar a la funcion para calcular el valor de imc
imc = CalcularIMC(peso, altura);

// Mostrar el resultado al usuario
if (imc > 0)
{
    Console.WriteLine("Su imc es: " + imc);
}

Console.WriteLine("Fin del programa");


// --- DEFINICIÓN DE FUNCIONES ---

// Funcion para calcular el IMC
double CalcularIMC(double peso, double altura)
{
    // Validar datos de entrada
    bool valido = ValidarEntrada(peso, altura);
    double resultado = 0;

    if (valido == true)
    {
        // Proceso
        resultado = peso / Math.Pow(altura, 2);
    }
    else
    {
        Console.WriteLine("Datos de entrada no validos");
    }

    return resultado;
}

// Funcion para validar los rangos de peso y altura
bool ValidarEntrada(double peso, double altura)
{
    bool valido = false;
    if (peso <= 400 && peso >= 5)
    {
        if (altura <= 2.5 && altura >= 0.6)
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Altura inválida");
            valido = false;
        }
    }
    else
    {
        Console.WriteLine("Peso inválido");
        valido = false;
    }
    return valido;
}