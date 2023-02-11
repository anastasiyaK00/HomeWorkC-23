// 6.В Указанном массиве вещественных чисел 
//найдите разницу между максимальным и минимальным элементом

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

int Minn(int[] s )
{
    int i=0;
    int l=s.Length;
     int p = i;
    while (i<l)
    {
        if (s[i]<p)
        {
            p = s[i];
        }
        i++;
    }
    return p;
}
int Max(int[] o )
{
    int i=0;
    int l=o.Length;
     int k = i;
    while (i<l)
    {
        if (o[i]>k)
        {
            k = o[i];
        }
        i++;
    }
    return k;
}
Fill(array);
Print(array);


int a= Max(array);
int b=Minn(array);

  Console.WriteLine($"{a},{b}");

