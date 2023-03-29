namespace LinkedListAsmnt
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack Problem");
            LinkedListQueue obj = new LinkedListQueue();
            obj.Enqueue(56);
            obj.Enqueue(30);
            obj.Enqueue(70);
            obj.Display();
        }
    }
}