// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int[8];

void Fill(int[] a)
{
    int lenght = a.Length;
    int index = 0;
    while (index < lenght)
    {
        a[index] = new Random().Next(0, 2);
        index++;
    }
}

void Print(int[] b)
{
    int l = b.Length;
    int p = 0;
    while (l > p)
    {
        Console.WriteLine(b[p]);
        p++;
    }
}
Fill(array);
Print(array);
