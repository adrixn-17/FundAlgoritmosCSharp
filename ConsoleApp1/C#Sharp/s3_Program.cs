// Programa que permite calcular el IMC
// Declarar las variables
double peso;
double altura;
double imc;

//Obtener datos del usuario
Console.WriteLine("Ingrese su peso (KG): ");
peso = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su altura (m): ");
altura = double.Parse(Console.ReadLine());

// Calcular el IMC
imc = peso / (altura * altura);

//Mostrar la informacion al usuario
Console.WriteLine("Su imc es: " + imc);