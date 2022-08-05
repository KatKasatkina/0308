// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(10);
    }
}



void MinSumLine(int[,] arr)
{
    int minSum = 0;
    int minLine = 0;
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
              for (int j = 0; j < n; j++)
        {
            sum = sum + arr[i, j];
            
        }
           if (i ==0) minSum = sum; 
          else if (sum < minSum)
           {
            minLine = i;
            minSum = sum;
           }
        }
       Console.WriteLine($"Минимальная сумма элементов в строке {minLine}."); 
    }
    


void PrintArray(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);

MinSumLine(array);
