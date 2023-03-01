// Контрольная работа
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна три символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello","2","world",":-)"] -> ["2",":-)"]
// ["1234","1567","-2","computer science"] -> ["-2"]
// ["Russia","Denmark","Kazan"] -> []

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintArray(string[] array)
{
    int len = array.Length;
    Console.Write("[");
    for (int i = 0; i < len - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    if (len > 0) Console.Write($"\"{array[len - 1]}\"");
    Console.Write($"]");
}

string[] GetArrayThree(string[] array)
{
    int len = array.Length;
    int countThree = 0;

    for (int i = 0; i < len; i++)
        if (array[i].Length <= 3)
            countThree++;

    string[] arrayReturn = new string[countThree];
    countThree = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayReturn[countThree] = array[i];
            countThree++;
        }
    }
    return arrayReturn;
}

// Размер массива
int count = GetNum("Введите размер массива: ");
string[] arrayStart = new string[count];
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    arrayStart[i] = Console.ReadLine();
}


string[] arrayEnd = GetArrayThree(arrayStart);

PrintArray(arrayStart);
Console.Write(" -> ");
PrintArray(arrayEnd);
Console.WriteLine();