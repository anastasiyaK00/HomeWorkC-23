//Написать программу масштабирования фигуры

// Определим что за фигура перед нами ( сколько имеет сторон)
System.Console.WriteLine("Введите количество сторон фигуры");
int side = int.Parse(Console.ReadLine() ?? "0");

//Зададим каждой стороне размер  при помощи массива

int[] arr = new int [side];
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
void PrintArray(int[] array) //Метод, печатающий наш массив
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.Write(" ");
}

void mashtab (int[] mash)
{
    
}



System.Console.WriteLine("Введите длину сторон: ");
FillArray(arr);
System.Console.WriteLine("Заданная фигура имеет следующую длину сторон: ");
PrintArray(arr);