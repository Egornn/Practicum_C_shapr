void PrintArray(string[] input)
{
    if (input.Length == 0) { System.Console.WriteLine("The array contains no fitting strings."); }
    else
    {
        for (int i = 0; i < input.Length - 1; i++)
        {
            System.Console.Write($"{input[i]}, ");
        }
        System.Console.WriteLine($"{input[input.Length - 1]}.");
    }
}


string[] FindStringsUnderGivenSize(string[] inputArray, int maxLength)
{
    int numberOfNeededStrings = 0;
    for (int counter = 0; counter < inputArray.Length; counter++)
    {
        if (inputArray[counter].Length <= maxLength)
        {
            numberOfNeededStrings++;
        }
    }
    string[] outputArray = new string[numberOfNeededStrings];
    int positionFromInput = 0;
    for (int counter = 0; counter < numberOfNeededStrings; counter++)
    {
        while (inputArray[positionFromInput].Length > maxLength)
        {
            positionFromInput++;
        }
        outputArray[counter] = inputArray[positionFromInput++];
    }
    return outputArray;
}


string[] initialArray = new string [] { "Monday", "Tuesday", "Wed", "Thu", "Friday", "Saturday", "Sun", "12,"};
int maxLength = 3;
string[] newArray = FindStringsUnderGivenSize(initialArray, maxLength);
PrintArray(newArray);