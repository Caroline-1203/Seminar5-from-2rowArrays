//  Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.


int[,] FillArray(int rows, int columns, int minValue, int MaxValue)
{
    int[,] array = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            array[i, l] = rand.Next(minValue, MaxValue + 1);

        }
    }
    return array;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(5, 5, 0, 10);
PrintArray(array);

Console.WriteLine();

for (int i = 0; i < array.GetLength(1); i++)
{
            int tmp = array[4, i];
                array[4, i] = array[0, i];
                array[0, i] = tmp;
}
 for(int i = 0; i < array.GetLength(0); i++)
 {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

