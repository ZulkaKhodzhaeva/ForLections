//Упорядочивание массива по порядку
//1) ищем минимальный элемент в неотсортированной части массива
//2) производим обмен местами с найденным значением
//3) повторяем пока есть неотсортированные элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 4 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)  //ищет максимальный элемент строки 25-31
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }    
        }
        int temporary = array[i];                   //производится свап строки 32-35
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);