/*                                     Задача 38:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

int InputNum(string message) // Метод запроса от пользователя размера массива.
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size) // метод создания массива.
{
    return new double[size];
}

void FillArray(double[] array) // Метод заполнения массива.
{
    int dev = 10;
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)

        array[i] = Math.Round((rnd.NextDouble() - 0.5) * 2 * dev, 2); //  Заполнение массива случайными числами.
}
string PrintArray(double[] array) // Метод печати массива.
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += array[i] + " ";
    return res;
}
double MaxNumbers(double[] array) // метод нахождения максимального элемента в массиве.
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[max])
            array[max] = array[i];
    }
    return array[max];
}
double MinNumbers(double[] array) // метод нахождения минимального элемента в массиве.
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[min])
            array[min] = array[i];
    }
    return array[min];
}

int size = InputNum("Введите размер массива: ");

double[] myArray = CreateArray(size);
FillArray(myArray);
string txt = PrintArray(myArray);
Console.WriteLine(txt);
double resultmax = MaxNumbers(myArray);
Console.WriteLine($"Максимальное число в массиве =  {resultmax}");
double resultmin = MinNumbers(myArray);
Console.WriteLine($"Минимальное число в массиве {resultmin}");
Console.WriteLine($"Разница между макc и мин элементов массива равна {resultmax - resultmin}");
