/*
Задача:
Задайте значения M и N.
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Использовать рекурсию, не использовать циклы.
*/

void Main()
{
    while (true)
    {
        string? m = ReadInt("Введите значение М: ");
        if (string.IsNullOrEmpty(m)) { PrinMsgNull(); break; }
        if (!int.TryParse(m, out int resultM)) { PrinMsgInvalidValue(); break; }
        int M = resultM;
        string? n = ReadInt("Введите значение N: ");
        if (string.IsNullOrEmpty(n)) { PrinMsgNull(); break; }
        if (!int.TryParse(n, out int resultN)) { PrinMsgInvalidValue(); break; }
        int N = resultN;

        if (N >= M)
        {
            PrintNaturNambers(M, N); // Рекурсивная функция
            break;
        }
        Console.WriteLine("Значение N находится ниже значения M. Измените условия ввода.");
        break;


        // Функции_________________________________

        void PrintNaturNambers(int n, int m)
        {
            if (n > m) return;
            PrintNaturNambers(n, m - 1);
            Console.Write(m + " ");
        }

        string? ReadInt(string msg)
        {
            System.Console.Write(msg);
            return Console.ReadLine();
            // Math.Abs(Convert.ToInt32(Console.ReadLine())); 
        }

        void PrinMsgNull()
        {
            Console.WriteLine("Вы не ввели значение. Повторите попытку.");
        }

        void PrinMsgInvalidValue()
        {
            Console.WriteLine("Введенное значение не соответствует условиям. Повторите попытку.");
        }
    }
}
Main();








