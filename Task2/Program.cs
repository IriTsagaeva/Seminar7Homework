int[,] CreateNewRandomArray(int rowCount, int colCount)
{
    int[,] array = new int[rowCount, colCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < colCount; column++)
        {
            array[row, column] = new Random().Next(0, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}

void ShowArrayElement(int[,] myArray, int position)
{
    // Позиция элемента определяется подсчетом по строкам слева направо, начиная с единицы. Например:
    //  1  2  3  4  5  6
    //  7  8  9 10 11 12
    // 13 14 15 16 17 18

    int myColumn = 0;
    int myRow = 0;
    if ((position) % myArray.GetLength(1)==0)
    {
        myColumn = myArray.GetLength(1)-1;
        myRow = (position) / myArray.GetLength(1)-1;
    }
    else
    {
        myColumn = (position-1)%myArray.GetLength(1);
        myRow = (position) / myArray.GetLength(1);
    }
    if (myRow >= myArray.GetLength(0))
    {
        System.Console.WriteLine("Такого элемента не существует!");
    }
    else
    {
        System.Console.WriteLine($"Элемент массива с индексами [{myRow},{myColumn}] равен {myArray[myRow, myColumn]}");
    }
}

Console.Clear();
int myRowCount = new Random().Next(1, 5);
int myColumnCount = new Random().Next(2, 5);
int[,] myArray = CreateNewRandomArray(myRowCount, myColumnCount);
PrintArray(myArray);
Console.WriteLine("Введите позицию элемента");
bool positionParse = Int32.TryParse(Console.ReadLine(), out int position);
if (positionParse && position >= 1)
{
    ShowArrayElement(myArray, position);
}
else
{
    Console.WriteLine("Пожалуйста, введите положительную целочисленную позицию элемента по строкам и столбцам");
}
Console.WriteLine();
