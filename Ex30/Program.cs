/*void FillArray(int[] collection)
{
    int lengh = collection.Length;
    int index = 0;
    while(index < lengh)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int[] array = new int[8];
*/


/*int N = 8;
int min = 0;
int max = 1;

int[] CreateArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

PrintArray(CreateArray(N, min, max));
*/

int[] GetBinaryArray (int size)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {result[i] = new Random().Next(2);
    }
    return result;
}
int[] testArray = GetBinaryArray (8);
Console.WriteLine($"Массив: [ {String.Join(",", testArray)} ]");


