

namespace _15_02_23
{
	internal class Program
	{
		private static object store;

		static void Main(string[] args)
		{
			Drink drink1 = new Drink();
			Drink drink2 = new Drink();

			Dairy dairy1 = new Dairy();
			Dairy dairy2 = new Dairy();

			store.AddProduct(dairy1);
			store.AddProduct(dairy2);
			store.AddProduct(drink1);
			store.AddProduct(drink2);

			System.Console.WriteLine(store.AlcoholPercentLimit());

			var arr = store.GetDrinkProducts();


			foreach (var item in arr)
			{
				System.Console.WriteLine($"{item.AlcoholPercent}{item}");
			}
			




			
		}
	}
}
