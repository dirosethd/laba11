using laba11;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект класса Computer
        Computer desktop = new Computer("Intel i7", 3200, 16);
        Console.WriteLine($"Качество настольного компьютера: {desktop.Quality()}");

        // Создаем объект класса Laptop
        Laptop laptop = new("Intel i5", 2500, 8, 512);
        Console.WriteLine($"Качество ноутбука: {laptop.Quality()}");
    }
}