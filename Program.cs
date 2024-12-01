namespace ImplementStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack p = new Stack();
            p.Push(10);
            p.Push(20);
            p.Push(30);
            Console.WriteLine(p.Pop());
            Console.WriteLine(p.Pop());
            Console.WriteLine(p.Pop());
        }
    }
}
