// Задача: Написать программу, которая из имеющегося 
// массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
const int charMaxCount = 3;
int rowCounter = 0;

Console.Write($"Введите количество строк: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] arr = new string[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.Write($"Введите текст для строки {i+1}: ");
    arr[i] = Console.ReadLine();
    if (arr[i].Length <= charMaxCount)
        rowCounter++;
}


string[] array = Search(arr, rowCounter, charMaxCount);

Console.Clear();
Console.Write("[");
for (int i = 0; i < arr.Length - 1; i++)
{
    Console.Write($"'{arr[i]}', ");
}
Console.Write($"'{arr[arr.Length - 1]}'");
Console.Write("] -> ");

Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"'{array[i]}', ");
}
Console.Write($"'{array[array.Length - 1]}'");
Console.Write("]");




string[] Search(string[] array, int validRowCount, int charMax)
{
    string[] result = new string[validRowCount];
    int j = 0;
    for (int i = 0; i <= validRowCount; i++)
    {
        if (array[i].Length <= charMax)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}