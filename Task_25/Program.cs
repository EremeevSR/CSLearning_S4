// Задача 25: Напишите программу, которая принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Задачу решить без использования Math.Pow.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Исходя из примера вывода при решении задачи будем
// ориентироваться на целочисленный ввод/вывод, при этом
// ограничение значений будет налагаться только на степень
// числа, которая должна быть натуральным числом,
// то есть лежать во множестве от 1 (включительно) до бесконечности.

bool IsNaturalPower(int power)
{
    //Метод проверки натуральности степени.
    if (power >= 1)
        return true;
    else
        return false;
}

int Power(int number, int power)
{
    // Метод возведения числа number в степень power.
    int result = 1;
    for(int i = 0; i < power; i++)
    {
        result *= number;
    }
    return result;
}

int PowerInput()
{
    // Метод ввода натуральной степени числа.
    Console.Write("Введите степень числа: ");
    int result = int.Parse(Console.ReadLine());
    while(!IsNaturalPower(result))
    {
        Console.WriteLine("Степень должна быть натуральным числом.\nПопробуйте снова: ");
        result = int.Parse(Console.ReadLine());
    }
    return result;
}

void ShowResult(int userNumber, int userPower)
{
    // Метод форматированного вывода результата 
    // возведения числа userNumber в степень userPower.
    Console.WriteLine($"Число {userNumber} в степени {userPower} равно {Power(userNumber, userPower)}");
}

Console.Write("Введите число: ");
int userNum = int.Parse(Console.ReadLine());
int userPow = PowerInput();
ShowResult(userNum, userPow);