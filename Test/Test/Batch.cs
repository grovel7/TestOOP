using System;
namespace Test
{
	public class Batch
	{

		private string _number;
		private string _name;
		private List<Transaction> _items = new List<Transaction>();

		public Batch(string number , string name)
		{
			_number = number;
			_name = name;
		}


        public void Add(Transaction transaction)	//to add a single order
        {
            _items.Add(transaction);
        }


		
        public void Print()
		{
			Console.WriteLine($"Batch Sale: #{_number}, {_name}");
			if(_items.Count == 0)
			{
				Console.WriteLine("Empty Order.");
			}
			else
			{
                foreach (Transaction i in _items)
                {
                    i.Print();
                }
                Console.WriteLine($"Total: ${Total()}");
            }
			
			

		}

		public decimal Total()
		{
			decimal totalSum = 0;
			foreach(Transaction i in _items)
			{
				totalSum = totalSum + i.Total();
			}
			return totalSum;
		}


		//readonly property

		public String Number 
		{
			get
			{
				return _number;
			}
		}

		public String Name
		{
			get
			{
				return _name;
			}
		}
	}
}

