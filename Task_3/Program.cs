/*
Задача:
Задайте произвольный массив.
Выведете его элементы, начиная с конца.
Использовать рекурсию, не использовать циклы.
*/
void Main()
{
    int[] MyArray = GeterateLineArray(5, 10, 99);
    Console.WriteLine("Исходный случайный массив:");
    PrintArray(MyArray);
    int count = MyArray.Length - 1;
    Console.WriteLine("\nЭлементы масива в обратном порядке:");
    PrintReversElemenArray(MyArray, count);


    // Функции___________________________________


    void PrintReversElemenArray(int[] array, int count)
    {
        if (count < 0)
        {
            return;
        }
        Console.Write(array[count] + " ");
        PrintReversElemenArray(array, count - 1);
        
    }
    
    
    int[] GeterateLineArray(int size, int leftBound, int rightBound)
    {
        int[] array = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(leftBound, rightBound + 1);
        }
        return array;
    }

    void PrintArray(int[] array)
    {
        string strArray = string.Join(" ", array);
        Console.Write($"[{strArray}]");
    }
}
Main();
