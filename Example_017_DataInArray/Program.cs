int[] array = {6, 8, 3, 2, 1, 4, 5, 7};

void PrintArray(int[] arr)
{
    int lenght = arr.Length;
    for(int index = 0; index < lenght; index++)
    {
        Console.Write($"{arr[index]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] Arr)
{
    for(int i = 0; i< Arr.Length - 1; i++)
    {
        int minPossition = i;
        for(int j = i + 1; j < Arr.Length; j++)
        {
            if(Arr[j] < Arr[minPossition])
            {
                minPossition = j;
            }
        }
        int temp = Arr[i];
        Arr[i] = Arr[minPossition];
        Arr[minPossition] = temp;
    }
}

void SelectionSortMax(int[] A)
{
    for(int i = A.Length - 1; i > 0; i--)
    {
        int maxPossition = i;
        for(int j = i - 1; j >= 0; j--)
        {
            if(A[j] < A[maxPossition])
            {
                maxPossition = j;
            }
        }
        int temp = A[i];
        A[i] = A[maxPossition];
        A[maxPossition] = temp;
    }
}


PrintArray(array);
SelectionSort(array);
PrintArray(array);
SelectionSortMax(array);
PrintArray(array);