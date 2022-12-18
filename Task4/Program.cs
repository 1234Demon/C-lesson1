Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = -a;

while(a > b)
{
    Console.Write(b);
    Console.Write(", ");
    b++;
}

Console.Write(b);