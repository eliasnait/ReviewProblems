Console.WriteLine("Is the lecture topic interesting?");
string input1 = Console.ReadLine();

Console.WriteLine("Does one of your friends join?");
string input2 = Console.ReadLine();

Console.WriteLine("Do you have problems with the assignment?");
string input3 = Console.ReadLine();

// y = true ------ alt andet = falsk
bool topic = input1 == "y";
bool friend = input2 == "y";
bool problem = input3 == "y";


if (topic && (friend || problem))
{
    Console.WriteLine("Go. ✅");
}
else
{
    Console.WriteLine("Stay. ❌");
}