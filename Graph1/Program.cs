namespace Graph1;

public class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\Users\\veron\\RiderProjects\\Graph1\\Graph1\\input.txt";

        Graph g = new Graph(filePath);

        Console.WriteLine("Исходная матрица смежности:");
        g.Show();
        
        Console.Write("Введите значение вершины a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите значение вершины b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nУдаляем ребро между вершинами {a} и {b}...");
        g.RemoveEdge(a, b);

        Console.WriteLine("\nМатрица смежности после удаления ребра:");
        g.Show();
    }
}