//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = n; i <= n % 2; i++);
 if ((n % 2 == 0) && !(n==1));

Console.WriteLine();
Console.Write($"{n%2<=0}");