// Задать массив, 
//заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел


int[] array = new int[11];//т.к. в условии не указан размер массива, определим его длину в 11 чисел

void Fill(int[] a)
{
    int lenght = a.Length;
    int index = 0;
    while (index < lenght)
    {
        a[index] = new Random().Next(99, 1000);
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

void Min(int[] min)
{
    int a = min.Length;
    int i = 0;
    int minim = 0;
    while (a > i)
    {
        if (min[i] % 2 == 0)
        {
            minim++;
        }
        i++;
    }
    Console.WriteLine(minim);
}

void Max(int[] max)
{
    int q = max.Length;
    int k = 0;
    int maxim = 0;
    while (q > k)
    {
        if (max[k] % 2 != 0)
        {
            maxim++;
        }
        k++;
    }
    Console.WriteLine(maxim);
}
Fill(array);
Print(array);
Console.WriteLine("Количество четных: ");
Min(array);
Console.WriteLine("Количество нечетных: ");
Max(array);
