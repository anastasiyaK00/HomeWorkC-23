              //Написать программу масштабирования фигуры

//я не поняла про какую фигуру идет речь.Здесь можно было бы задать
// количество сторон
//ввести массив и таким образом получить любую фигуру, 
//но я пока не понимаю 
//как это сделать, поэтому возьму за основу 4угольник

System.Console.WriteLine("Введите x1:");
int x1 = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите y1:");
int y1 = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите x2:");
int x2 = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите y2:");
int y2 = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите x3:");
int x3 = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите y3:");
int y3 = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите x4:");
int x4 = int.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Введите y4:");
int y4 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите + если нужно увеличить или - чтобы уменьшить");
string metod = Console.ReadLine();
Console.WriteLine("Введите коэф. масштабирования");
int k = int.Parse(Console.ReadLine() ?? "0");

int[] Array = { x1, y1, x2, y2, x3, y3, x4, y4 };

if (metod.ToLower() == "+")
{
    int length = Array.Length;
    for (int i = 0; i < length; i++)
    {
        Array[i] = Array[i] * k;
    }

}
else if (metod.ToLower() == "-")
{

    int length = Array.Length;
    for (int i = 0; i < length; i++)
    {
        Array[i] = Array[i] / k;
    }

}

void PrintArray(int[] col) // void-это метод, кот. ничего не возвращает 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
         Console.Write(col[position]);
         Console.WriteLine(" ");
        position++;
    }
}
PrintArray(Array);


// Я пsталась, постараюсь еще пересмотреть лекции и выполнить заново,
//  но пока больше ничего придумать не могу..