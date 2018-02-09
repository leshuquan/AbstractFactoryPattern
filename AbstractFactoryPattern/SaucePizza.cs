using System;

namespace AbstractFactoryPattern
{
	public class SaucePizza:Pizza
	{
		public SaucePizza (IPizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}
	}
}

