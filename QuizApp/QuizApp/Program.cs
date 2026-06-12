// See https://aka.ms/new-console-template for more information

using System.Linq;

StartQuiz();

static void StartQuiz()
{
    var questions = new (string Question, string Answer)[]
    {
        ("What is the capital of Germany", "Berlin"),
        ("What is 2+2", "4"),
        ("What color do you get by mixing blue and yellow", "Green"),
        ("What is the capital of Texas", "Austin")
    };

    int score = 0;

    foreach (var (question, answer) in questions)
    {
        Console.WriteLine(question);
        var userAnswer = Console.ReadLine();
        if (Normalize(userAnswer) == Normalize(answer))
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine($"Wrong, the correct answer is: {answer}");
        }
    }

    Console.WriteLine($"Quiz completed! Your final score is: {score}/{questions.Length}");
    if (score == questions.Length)
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
}

static string Normalize(string s)
{
    if (string.IsNullOrWhiteSpace(s)) return string.Empty;

    var cleaned = new string(s.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray()).ToLowerInvariant();
    var parts = cleaned.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    return string.Join(" ", parts);
}
