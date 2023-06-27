/*                                       Задача 36:
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int InputNum(string message) // Метод запроса от пользователя размера массива.
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size) // метод создания массива.
{
    return new int[size];
}

void FillArray(int[] array) // Метод заполнения массива.
{
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(-100, 100); //  Заполнение массива случайными положительными трёхзначными числами.
}
string PrintArray(int[] array) // Метод печати массива.
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}
int SumOfOddElements(int[] array) // Медот поиска суммы элементов стоящих на нечетных позициях.[1,3,5,7....и тд.]
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2) // i += 2
    {
        sum = sum + array[i]; //sum += array[i];
    }
    return sum;
}

int size = InputNum("Введите размер массива: ");

int[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
int res = SumOfOddElements(myArray);

Console.WriteLine(txt);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {res}");
