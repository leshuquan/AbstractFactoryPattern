using System;

namespace AbstractFactoryPattern
{
	public class CheesePizza:Pizza
	{
//		IPizzaIngredientFactory ingredientFactory;

		#region implemented abstract members of Pizza

//		public override void Prepare ()
//		{
//			Console.WriteLine ("Preparing "+name);
//			dough = ingredientFactory.CreateDough ();
//			cheese = ingredientFactory.CreateCheese ();
//			clam = ingredientFactory.CreateClams ();
//			sauce = ingredientFactory.CreateSauce();
//		}

		#endregion

		public CheesePizza (IPizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}
	}
}

