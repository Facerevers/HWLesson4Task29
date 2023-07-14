// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetMas(int numMin, int numMax, int number)
{
    int[] mas = new int[number];
    for (int i = 0; i < number; i++)
    {
        mas[i] = new Random().Next(numMin, numMax+1);
    }
    return mas;
}

void PrintMas(int[] mas)
{
    Console.Write("[");
    for (int i = 0; i< mas.Length -1; i++)
    {
        Console.Write($"{mas[i]},");
    }
    Console.Write($"{mas[mas.Length - 1]}");
    Console.Write("]");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int number = GetInput("Введите количество элементов массива: ");
int numMin = GetInput("Введите минимальное число массива: ");
int numMax = GetInput("Введите максимальное число массива: ");
int[] mas = GetMas(numMin, numMax, number);
PrintMas(mas);