// Задача 2: Напишите программу, которая 
//     на вход принимает два числа и Артём 
//     выдает, какое число большее, а какое меньшее.
//         a = 5; b = 7 ->  max = 7
//         a = 2 b = 10 -> max = 10
//         a = -9 b = -3 -> max = -3

Console.WriteLine("Hello, World!");
Console.WriteLine("Будем надеяться, что я смогу справиться со сравнением двух чисел (:");

Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Полагаю, что {number1} больше чем {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"min = {number1}, max = {number2}");
}
else
{
    Console.WriteLine("Блин! вот это ты задал задачку...");
    Console.WriteLine("Что-то мне подсказывает...");
    Console.WriteLine("что... они... равны...");
    Console.WriteLine(" ... ");
    Console.WriteLine("кажется...");
}
