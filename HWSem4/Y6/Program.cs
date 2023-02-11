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

void Minn(int[] s)
{
    int i=0;
    int l=s.Length;
    int min = i;
    while (i<l)
    {
        if (s[i]>min)
        {
            min = s[i];
        }
        i++;
    }
}
void Max(int[] t)
{
    int i=0;
    int l=t.Length;
    int max = i;
    while (i<l)
    {
        if (t[i]<max)
        {
            max = t[i];
        }
        i++;
    }
}
//присовить методам возвращаемое значение и сделать доп ссылку

void Search(int[] c)
{
    int a=Minn(array);
    int l=s.Length;
    int min = i;
    while (i<l)
    {
        if (s[i]>min)
        {
            min = s[i];
        }
        i++;
    }
}
Fill(array);
Print(array);
Console.WriteLine("Ответ: ");
Minn(array);