// See https://aka.ms/new-console-template for more information




double.TryParse(Console.ReadLine(), out double a);



bool isEven = a % 2 == 0 ? true : false;
Console.WriteLine(isEven ? a + "é par" : a + "é ímpar");
