int[,] CreateNewDoubleRandomArray(int rowCount, int colCount)
{
    int[,] array = new int[rowCount, colCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < colCount; column++)
        {
            array[row, column] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] GetColumnsArithmeticMean(int[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            resultArray[i] += array[j, i];
        }
        resultArray[i] = resultArray[i]/array.GetLength(0);
    }
    return resultArray;
}
void PrintArray(double[] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
       Console.WriteLine($"Столбец {row+1}: {String.Format("{0:f2}", array[row])} ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите количество строк");
bool rowParse = Int32.TryParse(Console.ReadLine(), out int myRowCount);
Console.WriteLine("Введите количество столбцов");
bool columnParse = Int32.TryParse(Console.ReadLine(), out int myColumnCount);
if (rowParse && columnParse && myRowCount > 0 && myColumnCount > 0)
{
    int[,] myArray = CreateNewDoubleRandomArray(myRowCount, myColumnCount);
    PrintMatrix(myArray);
    Console.WriteLine("Среднее арифметическое столбцов");
    PrintArray(GetColumnsArithmeticMean(myArray));
}
else
{
    Console.WriteLine("Пожалуйста, введите положительное целочисленное количество столбцов и строк");
}
