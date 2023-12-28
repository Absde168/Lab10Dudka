class Parallelepiped
{
    protected double length;
    protected double width;
    protected double height;

    public Parallelepiped(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double GetVolume()
    {
        return length * width * height;
    }
}

class MetalBar : Parallelepiped
{
    private double density;

    public MetalBar(double length, double width, double height, double density) : base(length, width, height)
    {
        this.density = density;
    }

    public double GetWeight()
    {
        return GetVolume() * density;
    }

    public string GetInfo()
    {
        return $"Dimensions: {length} x {width} x {height}, Density: {density}, Weight: {GetWeight()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект класса MetalBar
        MetalBar metalBar = new MetalBar(10, 5, 2, 7.8);

        // Выводим информацию о металлическом брусе
        Console.WriteLine(metalBar.GetInfo());

        Console.ReadLine();
    }
}