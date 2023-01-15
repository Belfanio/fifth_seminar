/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
//метод для инициализации массива рандомными числами
int[] InitArray(int dimension, int rightBound, int leftBound)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(leftBound, rightBound);
    }
    return result;
}

//метод для печати массива
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//1 Метод сумирования элементов массива, находящихся на нечетных позициях
int getOddFirst(int[] array)
{
    int Odd = 0;
    for (int i=0; i < array.Length; i+=2)
    {
        Odd += array[i];      
    }
    return Odd;
}

//2 Метод сумирования элементов массива, находящихся на нечетных позициях
int getOddSecond(int[] array)
{
    int Odd = 0;
    for (int i=0; i < array.Length; i++)
    {
        int newIndex = i+1;
        if (newIndex % 2 != 0)
        {
            Odd += array[i];
        }

              
    }
    return Odd;
}

int dimensin = GetNumber("Введите размерность массива");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
int[] arr = InitArray(dimensin, rightBound, leftBound);
PrintArray(arr);
int OddFirst = getOddFirst(arr);
int OddSecond = getOddSecond(arr);
Console.WriteLine($"Количество четных элементов массива {OddFirst}");
Console.WriteLine($"Количество четных элементов массива {OddSecond}");