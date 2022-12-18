Console.Write("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if(max < b) max = b;
if(max < c) max = c;

Console.Write("max = ");
Console.WriteLine(max);