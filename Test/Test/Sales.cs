using System;
namespace Test
{
	public class Sales
	{
		private List<Batch> _batch_orders = new List<Batch>();
		private List<Transaction> _single_orders = new List<Transaction>();


		public Sales()
		{

		}

		public void AddBatch(Batch batch)
		{
			_batch_orders.Add(batch);
		}

		public void AddTransaction(Transaction trans)
		{
			_single_orders.Add(trans);
		}

		public void PrintOrders()
		{
			decimal totalBatchOrder = 0;
			decimal totalTransOrder = 0;
			Console.WriteLine("Sale: ");
			foreach(Batch batch in _batch_orders)
			{
				batch.Print();
				totalBatchOrder = totalBatchOrder + batch.Total();
			}

            foreach (Transaction transaction in _single_orders)
            {
                transaction.Print();
                totalTransOrder = totalTransOrder + transaction.Total();
            }
			decimal totalSale = totalBatchOrder + totalTransOrder;
			Console.WriteLine("Sales total: $" + totalSale);
        }


	}
}

