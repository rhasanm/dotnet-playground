namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var bell = TheBell.Instance;
            bell.Ring();

            // Console.ReadKey();
        }
    }
}
