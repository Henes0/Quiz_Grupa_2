using Quiz;
using System.Runtime.Intrinsics.X86;

// Powołanie do życia obiektu game - który będzie zarządzał przebiegiem gry
var game = new Game();

// Wyświetlenie komunikatu powitalnego
game.DisplayWelcomeMessage();

// Zorganizowanie wszystkich pytań w grze
game.CreateQuestionDatabase();

// Losowanie pytania z najniżej kategorii
game.DrawQuestionFromCurrentCategory();

// Wyświetlanie pytania
game.CurrentQuestion.Display();

//pobranie numeru odpowiedzi od gracza
var userNumber = Console.ReadLine();

//Sprawdzanie odpowiedzi
var IsCorrect = game.CheckUserAnswer(userNumber);

Console.Clear();
if (IsCorrect)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Brawo to jest poprawna odpowiedź!");
    
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("niestety to jest zła odpowiedź");
    Console.WriteLine("GAME OVER");
}





Console.ReadLine();