void PrintArray (string [] input)
{
    for (int i = 0; i < input.Length - 1;i++)
    {
        System.Console.Write($"{input[i]}, ");
    }
    System.Console.WriteLine($"{input[input.Length-1]}.");
}
