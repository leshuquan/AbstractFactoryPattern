using System;

namespace AbstractFactoryPattern
{
	public class DoughPizza:Pizza
	{
		public DoughPizza (IPizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}
	}
}

