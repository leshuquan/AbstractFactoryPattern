using System;

namespace AbstractFactoryPattern
{
	/// <summary>
	/// 纽约原料工厂类
	/// </summary>
	public class NYPizzaIngredientFactory:IPizzaIngredientFactory
	{
		#region IPizzaIngredientFactory implementation

		public Dough CreateDough ()
		{
			return new ThinCrustDough ();
		}

		public Sauce CreateSauce ()
		{
			return new MarinaraSauce ();
		}

		public Cheese CreateCheese ()
		{
			return new ReggianoCheese ();
		}

		public Clams CreateClams ()
		{
			return new FreshClams ();
		}

		#endregion

		public NYPizzaIngredientFactory ()
		{
		}
	}
}

