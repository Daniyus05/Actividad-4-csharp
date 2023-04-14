// See https://aka.ms/new-console-template for more information
Console.WriteLine("¡Hola! a continuación le voy a pedir que me escriba dos números,seguidamente le indicaré si el segundo es par o impar. ");
Console.WriteLine("¿Cuál es el primer número que has elegido?");
var primerNumero = Console.ReadLine();
int numero1 = int.Parse(primerNumero);
Console.WriteLine("¿Cuál es el segundo número que has elegido?");
var segundoNumero = Console.ReadLine();
int numero2 = int.Parse(segundoNumero);
if (numero1 > numero2)
{
    Console.WriteLine("El primer número es mayor que el segundo número");
}
else if (numero1 < numero2)
{
    Console.WriteLine("El primer número es menor que el segundo número.");
}
else
{
    Console.WriteLine("El primer número es igual al segundo número.");
}
if (numero2 % 2 == 0)
{
    Console.WriteLine("El segundo número es par");
}
else
{
    Console.WriteLine("El segundo número es impar");
}