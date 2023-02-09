//4.Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[5];

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

void Sum(int[] s)
{
    int l = s.Length;
    int sum = 0;
    int i = 0;
    while (i < l)
    {
        if (s[i] % 2 != 0)
        {
            sum = sum + s[i];
        }
          i++;
    }
    Console.WriteLine(sum);
}
    Fill(array);
    Print(array);
    Console.WriteLine("Сумма чисел стоящих на нечетной позиции: ");
    Sum(array);
