// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

char genero;
int edad;

Console.Write("genero: ");
genero = Convert.ToChar(Console.ReadLine());

Console.Write("edad: ");
edad = Convert.ToInt32(Console.ReadLine());


if (edad >= 18 && genero == 'f')
{
    Console.WriteLine("Puede pasar gratis.");
}
else if (edad >= 18 && genero == 'm')
{
    Console.WriteLine("Tiene que pagar para pasar.");
}
else 
{
   ] Console.WriteLine("Vayase a estudiar");
}