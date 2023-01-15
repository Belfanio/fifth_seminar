/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

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

//Метод поиска Четных элементов
int getEven(int[] array)
{
    int Even = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            Even +=1;
    }
    return Even;
}


int dimensin = GetNumber("Введите размерность массива");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
int[] arr = InitArray(dimensin, rightBound, leftBound);
PrintArray(arr);
int Even = getEven(arr);
Console.WriteLine($"Количество четных элементов массива {Even}");