string word;
string sentence = "";

while (true)
{
    word = Console.ReadLine();
    sentence += word + " ";
    
    if (word.EndsWith("."))
        break;
}

Console.WriteLine(sentence);