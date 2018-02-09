using System;
namespace AbstractFactoryPattern
{
	/// <summary>
	/// 比萨枚举
	/// </summary>
	public enum PizzaType
	{
		Cheeese,
		Greek,
		Pepperoni,
		Clam,
		Veggie,
		Dough,
		Sauce
	}

	/// <summary>
	/// 比萨店接口
	/// </summary>
	public abstract class PizzaStore
	{

		public void orderPizza(PizzaType type)
		{
			Pizza pizza;
			pizza = CreatePizza(type);

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();

		}

		/// <summary>
		/// 工厂方法接口
		/// </summary>
		/// <returns>The pizza.</returns>
		/// <param name="type">Type.</param>
		public abstract Pizza CreatePizza(PizzaType type);
	}
}
