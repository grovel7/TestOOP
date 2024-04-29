using System;
namespace Test
{
	public class Sales
	{
		

		private List<Thing> _orders = new List<Thing>();


		public Sales()
		{

		}
		public void Add(Thing thing)
		{
			_orders.Add(thing);
		}

        public void PrintOrders()
        {
            decimal TotalSales = 0;
            Console.WriteLine("Sale: ");
            foreach (Thing order in _orders)
            {
                order.Print();
                TotalSales += order.Total();
            }
            Console.WriteLine($"Sales total: ${TotalSales}");
        }





    }
}

