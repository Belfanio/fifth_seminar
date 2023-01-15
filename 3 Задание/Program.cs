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


//первым возвращает минимальное число, вторым - максимальное
(int, int) GetMinMax(int[] array)
{
    int minNumber = array[1];
    int maxNumber = array[1];

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minNumber)
            minNumber = array[i];
        else if (array[i] > maxNumber)
            maxNumber = array[i];
    }

    return (minNumber, maxNumber);
}

//Поиск разницы между минимальным и максимальным элементами массива
int GetDifference(int minNumber, int maxNumber)
{
    int difference = maxNumber-minNumber;
    return difference;
}

int dimensin = GetNumber("Введите размерность массива");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
int[] arr = InitArray(dimensin, rightBound, leftBound);
PrintArray(arr);
(int minNumber, int maxNumber) = GetMinMax(arr);
int diff = GetDifference(minNumber, maxNumber);
Console.WriteLine($"Разница между минимальным элементом массива {minNumber} и максимальным элементом массива {maxNumber} равна {diff}");

