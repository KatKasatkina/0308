// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int m = 0;
int n = 0;

Console.Write("Введите m: ");
int.TryParse(Console.ReadLine(), out m); // lines

Console.Write("Введите n: ");
int.TryParse(Console.ReadLine(), out n); // columns

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);

            }
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
Console.WriteLine();

int[,] MaxToMin(int[,] arr)
{
    for (int i = 0; i < m; i++)
    {
            for (int j = 0; j < n; j++)
        {
           int max = j;                                            
            for (int k = j + 1; k < n; k++)                
            {
                if (array[i, k] > array[i, max]) max = k;    
            }
            int temp = array[i, j];                                          
            array[i, j] = array[i, max];                            
            array[i, max] = temp;      
        }
         
    }
   return array;  
}

MaxToMin(array);
PrintArray(array);

