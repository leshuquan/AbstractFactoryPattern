using System;

namespace AbstractFactoryPattern
{
	public class ClamPizza:Pizza
	{
		public ClamPizza (IPizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}
	}
}

