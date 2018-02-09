using System;

namespace AbstractFactoryPattern
{
	/// <summary>
	/// 原料工厂接口
	/// </summary>
	public interface IPizzaIngredientFactory
	{
		Dough CreateDough();
		Sauce CreateSauce();
		Cheese CreateCheese();
		Clams CreateClams();
	}
}

