class Circle
{
    private double x;
    private double y;
    private double r;

    public Circle(double x, double y, double radius)
    {
        this.x = x;
        this.y = y;
        this.r = radius;
    }

    public double GetX() => x;
    public double GetY() => y;
    public void SetX(double x) => this.x = x;
    public void SetY(double y) => this.y = y;
    public double GetRadius() => r;
    public void SetRadius(double radius) => r = radius;
}
class TestCircle
{
    static void Main(string[] args)
    {
        Circle c = new Circle(1.24, 2.83, 12.7);
        Console.WriteLine("x=" + c.GetX() + " y=" + c.GetY() + " r=" + c.GetRadius());
        c.SetRadius(c.GetRadius() * 1.37);
        c.SetX(c.GetX() + 0.65);
        Console.WriteLine("x=" + c.GetX() + " y=" + c.GetY() + " r=" + c.GetRadius());
    }
}