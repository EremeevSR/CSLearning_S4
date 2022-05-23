// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе. Задачу решить 
// без использования строк (string).
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Исходя из примера ввода/вывода при проверке пользовательского
// ввода ограничимся множеством положительных целых чисел.

bool IsPositiveInteger(int number)
{
    //Метод проверки пользовательского ввода.
    if (number >= 0)
        return true;
    else
        return false;
}

int NumOfDigits(int userNumber)
{
    // Метод определения количества цифер
    // digits в числе userNumber.
    int digits = 0;
    while(userNumber > 0)
    {
        digits++;
        userNumber /= 10;
    }
    return digits;
}

int[] NumberDecomposition(int userNumber)
{
    // Метод разложения числа на цифры.
    int[] arrOfDigits = new int[NumOfDigits(userNumber)];
    for(int i = 0; i < arrOfDigits.Length; i++)
    {
        arrOfDigits[i] = userNumber % 10;
        userNumber /= 10;
    }
    return arrOfDigits;
}

int SumOfNums(int[] arrOfNums)
{
    // Метод определения суммы цифр числа.
    int result = 0;
    for(int i = 0; i < arrOfNums.Length; i++)
    {
        result += arrOfNums[i];
    }
    return result;
}

int UserInput()
{
    // Метод пользовательского ввода.
    Console.Write("Введите целое положительно число: ");
    int result = int.Parse(Console.ReadLine());
    while(!IsPositiveInteger(result))
    {
        Console.Write("Будьте внимательны, введите ЦЕЛОЕ ПОЛОЖИТЕЛЬНОЕ число: ");
        result = int.Parse(Console.ReadLine());
    }
    return result;
}

void ShowResult()
{
    // Метод форматированного вывода результата суммирования цифр числа.
    Console.WriteLine($"Сумма цифер числа равна {SumOfNums(NumberDecomposition(UserInput()))}");
}

ShowResult();