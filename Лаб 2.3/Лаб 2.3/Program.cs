using System;
using System.IO;
using Newtonsoft.Json;

class Rectangle
{
    public double Length { get; set; } 
    public double Width { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public Rectangle(double length, double width, double x, double y)
    {
        Length = length;
        Width = width;
        X = x;
        Y = y;
    }

    public void Resize(double newLength, double newWidth)
    {
        Length = newLength;
        Width = newWidth;
    }

    public void Move(double deltaX, double deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }

    public Rectangle Union(Rectangle rect1, Rectangle rect2)
    {
        double minX = Math.Min(rect1.X, rect2.X);
        double minY = Math.Min(rect1.Y, rect2.Y);
        double maxX = Math.Max(rect1.X + rect1.Length, rect2.X + rect2.Length);
        double maxY = Math.Max(rect1.Y + rect1.Width, rect2.Y + rect2.Width);

        return new Rectangle(maxX - minX, maxY - minY, minX, minY);
    }

    public Rectangle Intersection(Rectangle rect1, Rectangle rect2)
    {
        double minX = Math.Max(rect1.X, rect2.X);
        double minY = Math.Max(rect1.Y, rect2.Y);
        double maxX = Math.Min(rect1.X + rect1.Length, rect2.X + rect2.Length);
        double maxY = Math.Min(rect1.Y + rect1.Width, rect2.Y + rect2.Width);

        if (maxX > minX && maxY > minY)
        {
            return new Rectangle(maxX - minX, maxY - minY, minX, minY);
        }
        else
        {
            return null; 
        }
    }

    public static void SaveToJson(Rectangle rectangle, string filePath)
    {
        string json = JsonConvert.SerializeObject(rectangle);
        File.WriteAllText(filePath, json);
    }

    public static Rectangle LoadFromJson(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<Rectangle>(json);
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect1 = new Rectangle(10, 5, 0, 0);
        Rectangle rect2 = new Rectangle(8, 6, 3, 2);

        Console.WriteLine("Initial Rectangles:");
        PrintRectangle("Rectangle 1", rect1);
        PrintRectangle("Rectangle 2", rect2);

        rect1.Resize(12, 6);
        rect2.Move(2, 3);

        Console.WriteLine("\nRectangles after modifications:");
        PrintRectangle("Rectangle 1", rect1);
        PrintRectangle("Rectangle 2", rect2);

        Rectangle unionRect = rect1.Union(rect1, rect2);
        Rectangle intersectionRect = rect1.Intersection(rect1, rect2);

        Console.WriteLine("\nUnion Rectangle:");
        PrintRectangle("Union", unionRect);

        Console.WriteLine("\nIntersection Rectangle:");
        if (intersectionRect != null)
        {
            PrintRectangle("Intersection", intersectionRect);
        }
        else
        {
            Console.WriteLine("No intersection.");
        }

        string filePath = "rectangle.json";
        Rectangle.SaveToJson(rect1, filePath);
        Rectangle loadedRect = Rectangle.LoadFromJson(filePath);

        Console.WriteLine("\nLoaded Rectangle from JSON:");
        PrintRectangle("Loaded Rectangle", loadedRect);
    }

    static void PrintRectangle(string name, Rectangle rectangle)
    {
        Console.WriteLine($"{name}: (Length: {rectangle.Length}, Width: {rectangle.Width}, X: {rectangle.X}, Y: {rectangle.Y})");
    }
}




