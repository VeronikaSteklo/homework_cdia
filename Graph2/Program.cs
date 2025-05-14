namespace Graph2;
public class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\Users\\veron\\RiderProjects\\Graph1\\Graph2\\input.txt";

        Graph g = new Graph(filePath);
       
        Console.Write("Введите значение вершины a: ");
        int a = int.Parse(Console.ReadLine());
        g.Dijkstra(a);
    }
}