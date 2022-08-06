string[] CreateStringArr(int n)
{
    string[] newArray = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Console.ReadLine();
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


int randomMin = 1;
int randomMax = 9;
int arrSize = new Random().Next(randomMin, randomMax+1);
Console.WriteLine($"Заполните количество {inputArraySize} элементов массива");

string[] inputArray = CreateStringArr(inputArray);