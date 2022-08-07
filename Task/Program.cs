string[] CreateStringArr(int size)
{
    string[] arrX = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element: ");
        arrX[i] = Convert.ToString(Console.ReadLine());
    }
    return arrX;
}

string[] countElement(string[] arrY)
{
    int count = 0;
    string[] newArray = new string[arrY.Length];
    for (int i = 0; i < arrY.Length; i++)
    {
        if (arrY[i].Length <= 3)
        {
            newArray[count] = arrY[i];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    for(int i =0; i<array.Length;i++)
    {
        Console.WriteLine($"[{array[i]}]");
    }
}

Console.WriteLine("Ввидите размер массива: ");
int element = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStringArr(element);
string[] newArray = countElement(array);
Console.WriteLine("->");
PrintArray(newArray);