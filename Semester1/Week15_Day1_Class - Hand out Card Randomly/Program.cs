

List<Player> Players = new List<Player>();
Players.Add(new Player("Melih"));
Players.Add(new Player("Mo"));
Players.Add(new Player("Nuno"));


int DECKSIZE = 52;
List<int> DeckOfCards = new List<int>();
for (int i = 0; i < DECKSIZE; i++)
{
    DeckOfCards.Add(i);
}



int card = 0;
Random random = new Random();
while (DeckOfCards.Count() >= 1)
{
    card = random.Next(DeckOfCards.Count());
    Players[0].Add(card);
    DeckOfCards.RemoveAt(card);

    card = random.Next(DeckOfCards.Count());
    Players[1].Add(card);
    DeckOfCards.RemoveAt(card);

    card = random.Next(DeckOfCards.Count());
    Players[2].Add(card);
    DeckOfCards.RemoveAt(card);
}

foreach (Player player in Players)
{
    foreach (int c in player.GetCards())
    {
        Console.WriteLine(c);
    }
}

Console.ReadLine();


public class Player
{
    private string _name;
    private List<int> Cards = new List<int>();

    public Player(string n)
    {
        _name = n;
    }

    public string Name { get => _name; }

    public void Add(int c)
    {
        Cards.Add(c);
    }

    public int[] GetCards()
    {
        return Cards.ToArray();
    }
}
