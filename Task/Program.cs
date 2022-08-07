string[] CreateStringArr(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToString(Console.ReadLine());
    }
    return newArray;
}

int countElement(string[] array)
{
    int elementCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) elementCount++;

    }
    return elementCount;
}

string[] outArr(string[] arr, int count)
{
    string[] arrOut = new string[count];
    int n = 0;
    for (int i = 0; n < arr.Length; i++)
    {
        if (arr[i].Length <=3)
            {
                arrOut[n] = arr[i];
                n++;
            }
    }
    return arrOut;
}

void PrintArray(string[] array)
{


}

Console.WriteLine("Ввидите размер массива: ");
int element = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStringArr(element);
