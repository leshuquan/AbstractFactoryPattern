using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern
{
	/// <summary>
	/// 产品类接口
	/// </summary>
	public abstract class Pizza
	{
		protected string name;

		public string Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}

		protected IPizzaIngredientFactory ingredientFactory;

		protected Dough dough;
		protected Sauce sauce;
		protected Veggies[] veggiesArray;
		protected Cheese cheese;
		protected Pepperoni pepperoni;
		protected Clams clam;
		protected List<string> toppings = new List<string>();

		public void Prepare (){
			Console.WriteLine ("Preparing "+name);
			dough = ingredientFactory.CreateDough ();
			cheese = ingredientFactory.CreateCheese ();
			clam = ingredientFactory.CreateClams ();
			sauce = ingredientFactory.CreateSauce();
		}

		public void Bake()
		{
			Console.WriteLine("Bake for 25 minutes at 350");
		}

		public void Cut()
		{
			Console.WriteLine("Cutting the pizza into diagonal slices");
		}

		public void Box()
		{
			Console.WriteLine("Place pizza in official PizzaStore box");
		}

	}
}

