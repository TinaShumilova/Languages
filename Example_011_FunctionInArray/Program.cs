void FillArray(int[] collection)
{
    int lenth = collection.Length;
    int index = 0;
    while(index < lenth)
    {
        collection[index] = new Random().Next(1,15);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int possition = 0;
    while(possition < count)
    {
        Console.WriteLine(col[possition]);
        possition++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;    
    }
    return position;
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);