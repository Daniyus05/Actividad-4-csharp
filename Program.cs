// See https://aka.ms/new-console-template for more information
Console.WriteLine("¡Hola! a continuación le voy a pedir que escriba dos números, seguidamente le indicaré cual es mayor o menor, o si son iguales y si el segundo es par o impar. ");
Console.WriteLine("¿Cuál es el primer número que has elegido?");
var primerNumero = Console.ReadLine();
int numero1 = int.Parse(primerNumero);
Console.WriteLine("¿Cuál es el segundo número que has elegido?");
var segundoNumero = Console.ReadLine();
int numero2 = int.Parse(segundoNumero);
if (numero1 > numero2)
{
    Console.WriteLine("El " + numero1 + " es mayor a " + numero2);
}
else if (numero1 < numero2)
{
    Console.WriteLine("El " + numero1 + " es menor a " + numero2);
}
else
{
    Console.WriteLine("El " + numero1 + " es igual a " + numero2);
}
if (numero2 % 2 == 0)
{
    Console.WriteLine("El " + numero2 + " es par");
}
else
{
    Console.WriteLine("El " + numero2 + " es impar");
}
