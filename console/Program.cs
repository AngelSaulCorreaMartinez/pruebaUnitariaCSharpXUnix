// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa otro numero");
int num2 = int.Parse(Console.ReadLine());
var calculator = new Calculator();
Console.WriteLine($"Total: {calculator.Sum(num1,num2)}");

