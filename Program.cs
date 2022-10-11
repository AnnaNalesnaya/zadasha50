// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int rowsArray = ImpytUsetNumber("введите первое значение ");
int columnsArray = ImpytUsetNumber("введите второе значение ");
int[,] arrayOfRandomNumbers = ArrayOfRandomNun(3, 4);
PrintArray(arrayOfRandomNumbers);
PrintValueInArray(arrayOfRandomNumbers, rowsArray, columnsArray);
int ImpytUsetNumber(string message)
{
    do
    {
        System.Console.Write(message + " => ");
        bool numberCorrect = int.TryParse(Console.ReadLine(), out int userImhut);
        if (numberCorrect)
        {
            return userImhut;        
        }
         else
        {
        System.Console.WriteLine("не правильный ввод");
        }
    
    }
    while(true);
}    
int[,] ArrayOfRandomNun( int rows, int columns)
{
    int[,] arrayRandom = new int [rows, columns];
    for (int i = 0; i < arrayRandom.GetLength(0); i ++)
    {
        for (int j = 0; j < arrayRandom.GetLength(1); j ++)
        {    
            arrayRandom[i, j] = (int)(new Random().Next(-999, 1000))/10;    
        }
    }
    return arrayRandom;
}    
void PrintArray(int[,] arrayImput)
{
   for (int i = 0; i < arrayImput.GetLength(0); i ++)
    {
    System.Console.Write("[");
    for (int j = 0; j < arrayImput.GetLength(1); j ++)
    {
        System.Console.Write("{0}", arrayImput[i, j]);
        if (j != (arrayImput.GetLength(1) -1))
        {
            System.Console.Write("\t ");
        }
    }
    System.Console.WriteLine("]");
    }
}   
void PrintValueInArray(int [,] arrayImput, int rows, int columns)
{
    System.Console.Write($"{rows}, {columns} => ");
    if (rows > 0 && columns< arrayImput.GetLength(1))
    {
        System.Console.WriteLine($"{arrayImput[rows, columns]}");
    }
    else
    {
        System.Console.WriteLine("такого числа нет");
    }
}