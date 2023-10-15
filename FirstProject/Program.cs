// See https://aka.ms/new-console-template for more information

public class Human
{
    private int age;
    public void setAge(int age)
    {
        this.age = age;
    }

    public int getAge()
    {
        return this.age;
    }
}

public class Program
{
    public static void Main(String[] args)
    {
        Human yamada = new Human();
        yamada.setAge(10);

        Console.WriteLine($"山田の年齢：{yamada.getAge()}");
    }
}