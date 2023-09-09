namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichBuilder builder;

            AssemblyLine shop = new AssemblyLine();

            builder = new HamAndCheese();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new BLT();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new TurkeyClub();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            // Console.ReadKey();
        }
    }
}
