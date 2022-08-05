// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int m = 2;
int n = 2;
int p = 2;

int[,,] array = new int[m, n, p];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       for (int k = 0; k < p; k++)
       {
        array[i, j, k] = new Random().Next(10);
        Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
       }
        Console.WriteLine();
    }
}

