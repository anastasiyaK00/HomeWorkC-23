// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число: ");
int S = int.Parse(Console.ReadLine() ?? "0");
int k = S;

int i = 0;
while (S > 0)
{
    S = S / 10;
    i++;
}
Console.WriteLine(i);
int[] array = new int[i - 1];

void FilArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        k = k / 10;
        collection[index] = k % 10;
        index++;
    }
}
void PrinArray(int[] col) // void-это метод, кот. ничего не возвращает 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

FilArray(array); // Заполнил массив
PrinArray(array); //Распечатал массив
Console.WriteLine();



/*
int[] array = new int[i];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        k = k / 10;
        collection[index] = k % 10;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
FillArray(array);
PrintArray(array);
*/
/*
int L(int i)
{
i=0;
while (S!=0)
{
    S=S/10;
    int result = i++;
    return result;
}
}
Console.WriteLine(L);



void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = (1,S);
        index++;
    }
}
*/