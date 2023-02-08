// Напишите программу, которая 
//     принимает на вход три числа 
//     и выдает максимальное из этих чисел.
//         2, 3, 7 -> 7
//         44 5 78 -> 78
//         22 3 9 -> 22

Console.WriteLine("Прив#т, Артём!.. так, это я что-то отвлекаюсь...");
Console.WriteLine("Нам же нужно определить максимальное из трёх чисел (:");

Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("и, наконец, Третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
Console.WriteLine("max = " + max);
