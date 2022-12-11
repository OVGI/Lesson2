/* Задача 5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. 
4 -> "-4,-3,-2,-1,0,1,2,3,4"
2 -> "-2,-1,0,1,2"  */

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
/*
int n = -N;
while (n < N)
{
    Console.Write($"{n} ");
    n++;

}
*/
for (int n = -N; n <= N; n++)
{
    Console.Write($"{n} ");
}

/*
if (N % 7 == 0 && N % 23 == 0)

    Console.Write($"да ");
else

    Console.Write($"нет: ");
*/

//int n;
//int N;



