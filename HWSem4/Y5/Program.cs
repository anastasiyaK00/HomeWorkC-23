// 5.Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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

void proizv(int[] s)
{
    int a = s.Length-1;
    int b = s.Length;
    int pr = 0;
    int i = 0;

    while (i < b)
    {
        pr = s[i] * s[a];
        Console.WriteLine($"произведение числа с индексом {i} на {a} = {pr} ");
        a=a-1;
        i++;
    }
}
Fill(array);
Print(array);
Console.WriteLine("Ответ: ");
proizv(array);
