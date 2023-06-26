/*                                     Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int InputNum(string message)    // Метод запроса от пользователя размера массива.
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)  // метод создания массива.
{
    return new int[size];
}

void FillArray(int[] array)  // Метод заполнения массива.
{
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 1000);      //  Заполнение массива случайными положительными трёхзначными числами.
}
string PrintArray(int[] array)     // Метод печати массива.
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}

int EvenNumbers(int[] array) // Метод поиска четных чисел в массиве.
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            index++;
    }
    return index;
}
int size = InputNum("Введите размер массива: ");

int[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
int num = EvenNumbers(myArray);
Console.WriteLine(txt);
Console.WriteLine($"количество чётных чисел в массиве: {num}");
