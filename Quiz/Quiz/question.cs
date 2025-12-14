namespace Quiz;

public class Question
{
    public int Id { get; set; }
    public int Category { get; set; }
    public string Content { get; set; }
    public List<Answer> Answers { get; set; } = new List<Answer>();

    public void Display()
    {
        Console.WriteLine($"Pytanie za {Category} pkt");
        Console.WriteLine();
        Console.WriteLine($"{Content}");
        Console.WriteLine();
        int answernumber = 1;
        foreach (var answer in Answers)
        {
            Console.WriteLine($" {answer.Id}. {answer.Content}");
            answernumber++;
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Wybierz prawidłową odpowiedź");
        Console.WriteLine("Naciśnij 1,2,3 lub 4 żeby wybrać odpowiedź");
        Console.ForegroundColor = ConsoleColor.White;
    }
}