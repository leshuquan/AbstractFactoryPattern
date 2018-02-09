using System;

namespace AbstractFactoryPattern
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PizzaStore store = new NYPizzaStore ();
			store.orderPizza (PizzaType.Cheeese);
			Console.WriteLine ("");
			store.orderPizza (PizzaType.Clam);
			Console.WriteLine ("");

			PizzaStore store2 = new ChicagoPizzaStore ();
			store2.orderPizza (PizzaType.Cheeese);
			Console.WriteLine ("");
			store2.orderPizza (PizzaType.Sauce);

		}
	}
}
