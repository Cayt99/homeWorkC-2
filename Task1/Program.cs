// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

 Console.Write("Введите трехзначное число: ");

        string input = Console.ReadLine();

        if (input.Length == 4 && input[0] == '-' && int.TryParse(input, out int number))
        {
            Console.WriteLine("Вторая цифра введенного числа: " + input[2]);
        }
        else if(input.Length == 3 && int.TryParse(input, out number))
        {
            Console.WriteLine("Вторая цифра введенного числа: " + input[1]); 
        }
        else
        {
            Console.WriteLine("Введено неверное число или вы ввели текст. Пожалуйста, введите трехзначное число.");
        }