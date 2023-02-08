// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];

void Fill(int[] a)
{
    int lenght = a.Length;
    int index = 0;
    while (index < lenght)
    {
        a[index] = new Random().Next(1, 200);// зададим диапазон 200, чтобы легче было проверить
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

void Search(int[] c)
{
    int s = c.Length;
    int i = 0;
    int k = 0;
    while (i < s)
    {
        if (c[i] < 99)
        {
            if (c[i] > 10)
            {
                k++;
                //Console.WriteLine(c[i]);
            }
        }
        i++;
    }
    Console.WriteLine(k);
}
Fill(array);
Print(array);
Console.WriteLine("Количество элементов из отрезка [10,99]: ");
Search(array);
