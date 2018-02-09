using System;

namespace AbstractFactoryPattern
{
	public class NYPizzaStore:PizzaStore
	{
		
		#region implemented abstract members of PizzaStore

		public override Pizza CreatePizza (PizzaType type)
		{
			Pizza pizza = null;
			IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory ();


			if (type == PizzaType.Cheeese) {
				pizza = new CheesePizza (ingredientFactory);
				pizza.Name = "New York Style Cheese Pizza";
				return pizza;
			} else if (type == PizzaType.Clam) {
				pizza = new ClamPizza (ingredientFactory);
				pizza.Name = "New York Style Clam Pizza";
				return pizza;
			} else if (type == PizzaType.Dough) {
				pizza = new DoughPizza (ingredientFactory);
				pizza.Name = "New York Style Dough Pizza";
				return pizza;
			} else if (type == PizzaType.Sauce) {
				pizza = new SaucePizza (ingredientFactory);
				pizza.Name = "New York Style Sauce Pizza";
				return pizza;
			} else
				return null;
		}

		#endregion

	}
}

