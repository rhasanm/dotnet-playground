namespace AbstractFactory
{
	// abstract product
	abstract class Sandwich {}
	abstract class Dessert {}

	// concrete product
	class BLT : Sandwich {}
	class PBandJ : Sandwich {}
	class CremeBrulee : Dessert {}
	class IceCreamSundae : Dessert {}

	// abstract factory
	abstract class RecipeFactory
	{
		public abstract Sandwich CreateSandwich();
		public abstract Dessert CreateDessert();
	}

	// concrete factory
	class AdultCuisineFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new BLT();
        }

        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }
    }
	class KidCuisineFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new PBandJ();
        }

        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }
    }
}
