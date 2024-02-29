/*
Задача:
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
*/

void Main()
{
    while (true)
    {
        Console.WriteLine("Рассчет функции Аккрмана");
        string? m = ReadInt("Введите значение переменной - m: ");
        if (string.IsNullOrEmpty(m)) { PrinMsgNull(); break; }
        if (!int.TryParse(m, out int resultM)) { PrinMsgInvalidValue(); break; }
        int M = resultM;
        string? n = ReadInt("Введите значение переменно - n: ");
        if (string.IsNullOrEmpty(n)) { PrinMsgNull(); break; }
        if (!int.TryParse(n, out int resultN)) { PrinMsgInvalidValue(); break; }
        int N = resultN;
        if (M >= 4 || N > 4) { Console.WriteLine("Не вводите значения переменных выше 4! Стек не выдержит :)"); break; }

        int result = AkkermanFunction(M, N);
        Console.WriteLine(result);
        break;
    }

    // Функции___________________________________

    int AkkermanFunction(int m, int n)
    {
        if (m == 0) { return (n + 1); }
        if (m > 0 && n == 0) { return AkkermanFunction(m - 1, 1); }
        if (m > 0 && n > 0) { return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)); }
        return 0;
    }


    string? ReadInt(string msg)
    {
        System.Console.Write(msg);
        return Console.ReadLine();
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
Main();



