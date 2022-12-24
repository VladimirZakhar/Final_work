
string[] inputArray = {"hello", "2", "world", ":-)" };
int sizeNewArray = 0;
int maxLenght = 3;
Console.Write($"Вводимый массив: ");
PrintArray(inputArray);
string[] tempArray = new string[inputArray.Length];
tempArray = arraySelection(inputArray, maxLenght);
string[] newArray = new string[sizeNewArray];
newArray = arrayEditing(tempArray, sizeNewArray);
Console.Write($"Новый массив: ");
PrintArray(newArray);

string[] arraySelection(string[] inputArray, int length)
{
    string[] tempArray = new string[inputArray.Length];
    int j = 0;
    foreach (var item in inputArray)
    {
        if (item.Length <= length)
        {
            tempArray[j++] = item;
        }
    }
    sizeNewArray = j;
    return tempArray;
}

string[] arrayEditing(string[] inputArray, int count)
{
    string[] tempArray = new string[count];
    int i = 0;
    while (i < count) tempArray[i] = inputArray[i++];
    return tempArray;
}

void PrintArray(string[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
