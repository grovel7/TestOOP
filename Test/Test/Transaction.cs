using System;
namespace Test
{
	public class Transaction
	{
		private string _number;
		private string _name;
		private decimal _amount;


		public Transaction(string number , string name , decimal amount)
		{
			_number = number;
			_name = name;
			_amount = amount;
		}

		public void Print()
		{
            Console.WriteLine($"#{_number} , {_name} , {_amount:C}");
          
        }

		public decimal Total()
		{
			return _amount;
		}

		

		//property


		public string Number
		{
			get
			{
				return _number;
			}
		}


		public string Name
		{
			get
			{
				return Name;
			}
		}
		

	}
}

