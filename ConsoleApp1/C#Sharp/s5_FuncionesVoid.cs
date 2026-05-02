// Declarar variables
string nombreCompleto = "";
// Solicitar al usuario su nombre completo
Console.WriteLine("Ingresa tu nombre: ");
nombreCompleto = Console.ReadLine();
// Mostrar informacion del usuario
saludar(nombreCompleto);

void saludar(string nombres)
{
    Console.WriteLine("Hola " + nombres + " Bienvenido a mi Sistema");
}