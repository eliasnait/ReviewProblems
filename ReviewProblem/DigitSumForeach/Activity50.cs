Console.WriteLine("Enter an integer");
string input = Console.ReadLine();

int sum = 0;

foreach (char digitChar in input)
{
    if (int.TryParse(digitChar.ToString(), out int digit))
    {
        sum += digit;
    }
}

Console.WriteLine("Sum: " + sum);