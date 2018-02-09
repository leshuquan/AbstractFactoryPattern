using System;

namespace AbstractFactoryPattern
{
	public class ChicagoPizzaStore:PizzaStore
	{
		#region implemented abstract members of PizzaStore

		public override Pizza CreatePizza (PizzaType type)
		{

			Pizza pizza = null;
			IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactrory ();


			if (type == PizzaType.Cheeese) {
				pizza = new CheesePizza (ingredientFactory);
				pizza.Name = "Chicago Style Cheese Pizza";
				return pizza;
			} else if (type == PizzaType.Clam) {
				pizza = new ClamPizza (ingredientFactory);
				pizza.Name = "Chicago Style Clam Pizza";
				return pizza;
			} else if (type == PizzaType.Dough) {
				pizza = new DoughPizza (ingredientFactory);
				pizza.Name = "Chicago Style Dough Pizza";
				return pizza;
			} else if (type == PizzaType.Sauce) {
				pizza = new SaucePizza (ingredientFactory);
				pizza.Name = "Chicago Style Sauce Pizza";
				return pizza;
			} else
				return null;
		}

		#endregion

		public ChicagoPizzaStore ()
		{
		}


	}
}

