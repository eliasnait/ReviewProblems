Console.WriteLine("Enter dividend");
string input1 = Console.ReadLine();
decimal dividend = decimal.Parse(input1);

Console.WriteLine("Enter divisor");
string input2 = Console.ReadLine();
decimal divisor = decimal.Parse(input2);

if (dividend % divisor == 0)
{
    Console.WriteLine("Multiples");
}
else
{
    Console.WriteLine("Not multiples");
}