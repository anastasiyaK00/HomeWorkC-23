// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число: ");
int S = int.Parse(Console.ReadLine() ?? "0");
int k=S;

int i=0;
while (S!=0)
{
    S=S/10;
    i++;
}
Console.WriteLine(i);



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