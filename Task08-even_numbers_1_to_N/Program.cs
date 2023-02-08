// Задача 8: Напишите программу, которая 
//     на вход принимает число (N), 
//     а на выходе показывает все чётные числа от 1 до N.
//         5 -> 2, 4
//         8 -> 2, 4, 6, 8

Console.Write("Очередное число в console: ");
double number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    for (int i = 2; i <= number; i += 2)
    {
        Console.Write(i + " ");
    }
}
else if (number < -1)
{
    for (int i = 0; i >= number; i -= 2)
    {
        Console.Write(i + " ");
    }
}
else
{
    Console.Clear();
    Console.SetCursorPosition(5,3);
    Console.Write("Ну, вот, ты всё и поломал!");
    Console.SetCursorPosition(7,5);
    Console.Write("А я так старался");
    Console.SetCursorPosition(7,7);
}