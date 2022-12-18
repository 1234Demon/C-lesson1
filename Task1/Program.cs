Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
//int.Parse преобразование числа

int sq = (int)Math.Pow(number, 3);

Console.WriteLine(sq);