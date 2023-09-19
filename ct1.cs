public class MathOperations
{
    public int SUM(int a, int b)
    {
        return a + b;
    }

    public int SUM(int a, int b, int c)
    {
        return a + b + c;
    }

    public int SUM(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }
}
public class Plant
{
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Width { get; set; }

    public Plant(int height, int weight) : this(height, weight, 0)
    {

    }

    public Plant(int height, int weight, int width)
    {
        this.Height = height;
        this.Weight = weight;
        this.Width = width;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Height: {Height}, Weight: {Weight}, Width: {Width}");
    }
}
class Program
{
    static void Main()
    {
        MathOperations operations = new MathOperations();
        Console.WriteLine(operations.SUM(2, 3));
        Console.WriteLine(operations.SUM(2, 3, 4));
        Console.WriteLine(operations.SUM(2, 3, 4, 5));

        Plant plant1 = new Plant(150, 2);
        Plant plant2 = new Plant(180, 3, 50);

        plant1.DisplayInfo();
        plant2.DisplayInfo();
    }
}
end
azzazaz
