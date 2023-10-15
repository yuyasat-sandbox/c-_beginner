public class Program
{
    public static void Main()
    {
        var kukiwakame = new Snack("茎わかめ", 300, 15);
        kukiwakame.displayTotalPriceText();

        var uguisu = new Snack("鶯ボール", 200, 10);
        uguisu.displayTotalPriceText();

        var senbei = new Snack("せんべい", 700, 15);
        senbei.displayTotalPriceText();
    }
}

public class Snack
{
    string name;
    int price;
    int quantity;
    public Snack(string name, int price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public int GetTotalPrice()
    {
        return price * quantity;
    }

    public void displayTotalPriceText()
    {
        Console.WriteLine($"{name}合計金額は、{GetTotalPrice()}円です。");
    }
}