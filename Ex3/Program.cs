// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[,] array = FillArray(3, 5, 0, 6);
PrintArray(array);

Console.WriteLine();


int min_sum = 0;

int min_sum_row = 0;

for (int j = 0; j < array.GetLength(1); j++)

{

    min_sum += array[0, j];

}

for (int i = 1; i < array.GetLength(0); i++)

{

    int sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)

    {

        sum += array[i, j];

    }

    if (sum < min_sum)

    {

        min_sum = sum;

        min_sum_row = i;

    }

}
Console.WriteLine($"Строка с наименьшей суммой элементов: {min_sum_row}");
