// копирование массива


System.Console.WriteLine("Введите количество элементов массива'");
int s = int.Parse(Console.ReadLine() ?? "0");
int [] array = new int [s];
System.Console.WriteLine("Поочередено введите каждый элемент массива");

FillArray(array);
PrintArray(array);
CopyArray(array);


void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = int.Parse(Console.ReadLine() ?? "0");
        index++;
    }
}
void PrintArray(int[] array) 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.Write(" ");
}
void CopyArray(int[] collection)
{
    int Length = array.Length;
    int [] copy = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i]=array[i];
    }
    Console.Write(copy); Console.Write(",");
}