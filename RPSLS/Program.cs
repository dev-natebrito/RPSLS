using RPSLS.RPSLS;

internal class Program
{
    static void Main(string[] args)
    {
        // Type your username and press enter
        Console.WriteLine("Enter Player 1 Hand form:\n" +
                          "1 - Rock\n" +
                          "2 - Paper\n" +
                          "3 - Scissors\n" +
                          "4 - Lizard\n" +
                          "5 - Spock\n");
        string? sp1 = Console.ReadLine();
        int p1 = Convert.ToInt32(sp1);


        Console.WriteLine("Enter Player 2 Hand form:\n" +
                          "1 - Rock\n" +
                          "2 - Paper\n" +
                          "3 - Scissors\n" +
                          "4 - Lizard\n" +
                          "5 - Spock\n");
        string? sp2 = Console.ReadLine();
        int p2 = Convert.ToInt32(sp2);


        PossibleResults result = new Jokenpo().PlayGame(ToPlayer(p1), ToPlayer(p2));

        Console.WriteLine($"player 1: {result}");
    }


    static Player ToPlayer(int i)
    {
        Player player = new Player();

        player.HandForm = i switch
        {
            1 => HandForm.Rock,
            2 => HandForm.Paper,
            3 => HandForm.Scissors,
            4 => HandForm.Lizard,
            5 => HandForm.Spock,
            _ => throw new ArgumentException("There is no hand form for this number ")
        };

        return player;
    }
}