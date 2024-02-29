/*
Задача:
Задайте произвольный массив.
Выведете его элементы, начиная с конца.
Использовать рекурсию, не использовать циклы.
*/
void Main ()
{
    int[] MyArray = GeterateLineArray(8, 10, 99);
    

// Функции
int[] GeterateLineArray (int size, int leftBound, int rightBound)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next (leftBound, rightBound + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}




}
Main();
