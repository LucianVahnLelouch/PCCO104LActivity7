using System;
public class Game
{

    public string Title { get; set; }
    public string Developers { get; set; }
    public int Year { get; set; }
    private bool Availability;
    private string genre;


    public Game()
    {
        Title = "Unknown";
        Developers = "Unknown";
        Year = 0;
        Availability = true;
        genre = "Unknown";
    }


    public Game(string title, string developers, int year)
    {
        Title = title;
        Developers = developers;
        Year = year;
        Availability = true;
        genre = "Unknown";
    }


    public Game(string title, string developers, int year, bool Availability, string genre)
    {
        Title = title;
        Developers = developers;
        Year = year;
        this.Availability = Availability;
        this.genre = genre;
    }
    public void BuyGame()
    {
        if (Availability)
        {
            Availability = false;
            Console.WriteLine("Thank you for the purchase!");
        }
        else
        {
            Console.WriteLine("We unfortunately do not have this game in stock.");
        }
    }
    public void DisplayGameInfo()
    {
        Console.WriteLine($"Game: {Title}, Developers: {Developers}, Publication Year: {Year}");
    }
}
public class Program
{
    static void Main(string[] args)
    {

        Game firstgame = new Game("Silent Hill", "Konami",  1999,true,"Horror");
        Game secondgame = new Game("Minecraft", "Mohjang", 2009);
        Game thirdgame = new Game("Breath of the Wild", "Nintendo", 2017, false,"Science Fiction");
        Game fourthgame = new Game("God of War", "Santa Monica Studio", 2018);
      
        firstgame.DisplayGameInfo();
        firstgame.BuyGame();
        secondgame.DisplayGameInfo();
        secondgame.BuyGame();
        thirdgame.DisplayGameInfo();
        thirdgame.BuyGame();
        fourthgame.DisplayGameInfo();
        fourthgame.BuyGame();
    }
  }