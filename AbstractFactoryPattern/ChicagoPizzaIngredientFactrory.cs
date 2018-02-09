using System;

namespace AbstractFactoryPattern
{
	/// <summary>
	/// 芝加哥原料工厂类
	/// </summary>
	public class ChicagoPizzaIngredientFactrory:IPizzaIngredientFactory
	{
		#region IPizzaIngredientFactory implementation

		public Dough CreateDough ()
		{
			return new ThickCrustDough ();
		}

		public Sauce CreateSauce ()
		{
			return new PlumTomatoSauce ();
		}

		public Cheese CreateCheese ()
		{
			return new MozzarellaCheese ();
		}

		public Clams CreateClams ()
		{
			return new FrozenClams ();
		}

		#endregion

		public ChicagoPizzaIngredientFactrory ()
		{
		}
	}
}

