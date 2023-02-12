// 6.В Указанном массиве вещественных чисел 
//найдите разницу между максимальным и минимальным элементом

int [] array = new int[5];

void Fill(int[] a)
{
    int lenght = a.Length;
    int index = 0;
    while (index < lenght)
    {
        a[index] = new Random().Next(1, 199);
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

int Minn(int[] s)
{
    int i = 0;
    int l = s.Length;
    int p = s[i];
    while (i < l)
    {
        if (s[i] < p)
        {
            p = s[i];
        }
        i++;
    }
    return p;
}

int Max(int[] o)
{
    int i = 0;
    int l = o.Length;
    int k = 0;
    while (i < l)
    {
        if (o[i] > k)
        {
            k = o[i];
        }
        i++;
    }
    return k;
}

Fill(array);
Print(array);

int a = Max(array);
Console.WriteLine($"Маскимальное число в массиве = {a}");
int b = Minn(array);
Console.WriteLine($"Минимальное число в массиве = {b}");

int j = a-b;
Console.WriteLine($"Разница между максимальным и минимальным элементом = {j}");