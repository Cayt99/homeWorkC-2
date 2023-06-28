// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Console.Write("Понедельник - это рабочий день");
        break;

    case 2:
        Console.Write("Вторник - это рабочий день");
        break;

    case 3:
        Console.Write("Среда - это рабочий день");
        break;
    case 4:
        Console.Write("Четверг - это рабочий день");
        break;

    case 5:
        Console.Write("Пятница - это рабочий день");
        break;

    case 6:
        Console.Write("Суббота - это выходной день");
        break;

    case 7:
        Console.Write("Воскресенье - это выходной день");
        break;

    default:
        Console.Write("Вы ввели некорректное значение");
        break;

}
