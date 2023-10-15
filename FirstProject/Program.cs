public class Program
{
    public static void Main()
    {
        var player1 = new Player("勇者テム");
        player1.Attack();

        var player2 = new Player("勇者トム");
        player2.Attack();
        player1.Attack();
    }
}

public class Player
{
    private string name;

    public Player(string name)
    {
        this.name = name;
    }
    public void Attack()
    {
        Console.WriteLine($"{name}はスライムに攻撃した。");
    }
}