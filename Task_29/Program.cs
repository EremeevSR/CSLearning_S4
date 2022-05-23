// Задача 29: Напишите программу, которая задаёт 
// массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Поскольку пользователь в данной программе определяет
// лишь размер массива, то именно этот параметр будет
// проверяться на корректность ввода: размер массива
// ограничен множеством натуральных чисел, то есть от 1
// до бесконечности. Диапазон значений массива ограничим
// положительными целыми числами от 1 до 99.

bool IsNaturalNumber(int number)
{
    //Метод проверки натуральности числа.
    if (number >= 1)
        return true;
    else
        return false;
}

int UserInput()
{
    // Метод пользовательского ввода.
    Console.Write("Введите размер массива случайных чисел: ");
    int result = int.Parse(Console.ReadLine());
    while(!IsNaturalNumber(result))
    {
        Console.Write("Размер массива должен быть больше 0, попробуйте снова: ");
        result = int.Parse(Console.ReadLine());
    }
    return result;
}

int[] CreateRandomArray(int size)
{
    // Метод формирования массива размером size
    // значений от 1 до 99.
    Random rndNum = new Random();
    int[] rndArr = new int[size];
    for(int i = 0; i < size; i++)
    {
        rndArr[i] = rndNum.Next(1,99);
    }
    return rndArr;
}

void ShowRandomArray(int[] rndArr)
{
    // Метод форматированного вывода массива rndArr.
    Console.Write("[");
    for (int i = 0; i < rndArr.Length - 1; i++)
        Console.Write($"{rndArr[i]}, ");
    Console.WriteLine($"{rndArr[rndArr.Length - 1]}]");
}

ShowRandomArray(CreateRandomArray(UserInput()));