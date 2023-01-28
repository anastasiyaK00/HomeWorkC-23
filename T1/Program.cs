// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите 1-ое число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Dедите 2-ое число B: ");
int B = int.Parse(Console.ReadLine());


if (A * A == B)
    Console.WriteLine($"  B = {B} - является квадратом числа A({A})");
if (B * B == A)
    Console.WriteLine($"  A = {A} - является квадратом числа B({B})");


/*else

       Console.WriteLine("Ни A, ни B не являются квадратами друг друга");
       как сделать, чтобы не выходила последняя стркоа
*/

