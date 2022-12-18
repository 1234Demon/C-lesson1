Console.Write("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if(a < b) max = b;

Console.Write("max = ");
Console.Write(max);