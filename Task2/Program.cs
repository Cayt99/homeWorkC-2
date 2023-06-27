// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        
        if (input.Length > 10 || !int.TryParse(input.Replace("-", ""), out int number))
        {
            Console.WriteLine("Введено неверное число или вы ввели текст. Пожалуйста, введите число до 10 символов.");
        }
        else if(input.Length >= 3)
        {
            int position = input[0] == '-' ? 4 : 3;
            Console.WriteLine("Третья цифра введенного числа: " + input[position-1]);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет.");
        }