/*
Задача:
Задайте произвольный массив.
Выведете его элементы, начиная с конца.
Использовать рекурсию, не использовать циклы.
*/
void Main ()
{

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
}
Main();
