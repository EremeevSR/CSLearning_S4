// Доп. задача:
// Напишите функцию, которая принимает слово и возвращает true,
// если в этом слове есть две одинаковые, стоящие рядом буквы.
// "ссора" -> true
// "клюющий" -> true
// "кодер" -> false
// "цыпленок"-> false

// Перед решением задачи определимся с тем, что с точки зрения
// программы будет является словом. Положим, что слово - строка
// ненулевой длинны, состоящая исключительно из буквенных символов,
// то есть начинается и заканчивается буквой, не содержит цифр и
// иных символов.
// Например:
// "Слово"  - слово;
// "С"      - слово;
// "Слово " - не слово (оканчивается символом пробела);
// ""       - не слово;
// "Сло,во" - не слово;
// "Сл0во"  - не слово;
// "Слово и что-то ещё" - не слово.

bool IsWord(string someString)
{
    // Метод проверки строки на то,
    // является ли она словом.
    if(string.IsNullOrEmpty(someString)) return false;

    for(int i = 0; i < someString.Length; i++)
    {
        if(!(char.IsLetter(someString[i]))) return false;
    }

    return true;
}

string UserInput()
{
    // Метод пользовательского ввода.
    Console.Write("Введите слово: ");
    string result = Console.ReadLine();
    while(!IsWord(result))
    {
        Console.Write("Ввод не является словом, попробуйте снова: ");
        result = Console.ReadLine();
    }
    return result;
}

bool ContainsDoubleCharacters(string someWord)
{
    // Метод, который проверяет содержит ли
    // введенное пользователем слово две идущие
    // подряд одинаковые буквы.
    if(someWord.Length == 1) return false;
    for(int i = 0; i < someWord.Length - 1; i++)
    {
        if(someWord[i] == someWord[i+1]) return true;
    }
    return false;
}

void ShowResult(bool WordContainsDoubleCharacters)
{
    // Метод, который использует реализованную функцию
    // для вывода информации о наличии в слове двойных
    // подряд идущих букв.
    if(WordContainsDoubleCharacters)
        Console.WriteLine("Слово содержит две одинаковые, стоящие рядом буквы");
    else
        Console.WriteLine("Слово не содержит двух одинаковых, стоящих рядом букв");
}

ShowResult(ContainsDoubleCharacters(UserInput()));