// See https://aka.ms/new-console-template for more information

using System.Text;

string question1 = "What is the capital of Germany";
string answer1 = "Berlin";

string question2 = "What is 2+2";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow";
string answer3 = "Green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (Normalize(userAnswer1) == Normalize(answer1))
{
    Console.WriteLine("Correct!");
    score = score + 1;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer1);
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (Normalize(userAnswer2) == Normalize(answer2))
{
    Console.WriteLine("Correct!");
    score = score + 1;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer2);
}


Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (Normalize(userAnswer3) == Normalize(answer3))
{
    Console.WriteLine("Correct!");
    score = score + 1;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer3);
}

Console.WriteLine($"Quiz completed! Your final score is: {score}/3");
if (score == 3)
{
    Console.WriteLine("Excellent! You got all the answers right!");
}
else if (score > 0)
{
    Console.WriteLine("Good Job, but keep learning!");
}
else
{
    Console.WriteLine("Try again and see if you can get some answers right next time!");
}


Console.ReadKey();

static string Normalize(string s)
{
    if (string.IsNullOrWhiteSpace(s)) return string.Empty;

    var sb = new StringBuilder();
    foreach (var c in s)
    {
        if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
        {
            sb.Append(char.ToLowerInvariant(c));
        }
        // skip punctuation and other characters
    }

    var parts = sb.ToString().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    return string.Join(" ", parts).Trim();
}
