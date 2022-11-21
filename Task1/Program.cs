double[,] CreateNewDoubleRandomArray(int rowCount, int colCount)
{
    double[,] array = new double[rowCount, colCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < colCount; column++)
        {
            array[row, column] = new Random().NextDouble() * 100;
        }
    }
    return array;
}

void PrintArray (double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(String.Format("{0:f2}", array[row,column])+ " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк");
bool rowParse = Int32.TryParse(Console.ReadLine(), out int myRowCount);
Console.WriteLine("Введите количество столбцов");
bool columnParse = Int32.TryParse(Console.ReadLine(), out int myColumnCount);
if (rowParse && columnParse && myRowCount > 0 && myColumnCount > 0)
{
    double[,] myArray = CreateNewDoubleRandomArray(myRowCount, myColumnCount);
    PrintArray(myArray);
}
else
{
    Console.WriteLine("Пожалуйста, введите положительное целочисленное количество столбцов и строк");
}
