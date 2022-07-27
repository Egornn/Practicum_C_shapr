void PrintArray (string [] input)
{
    for (int i = 0; i < input.Length - 1;i++)
    {
        System.Console.Write($"{input[i]}, ");
    }
    System.Console.WriteLine($"{input[input.Length-1]}.");
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