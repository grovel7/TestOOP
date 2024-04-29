using System;
namespace Test
{
	public class Batch : Thing
	{

		private List<Thing> _items = new List<Thing>();

		public Batch(string number , string name) : base(number , name)
		{
			
		}


        public void Add(Thing thing)	
        {
            _items.Add(thing);
        }



        public override void Print()
        {

            Console.WriteLine($"Batch Sale: #{Number}, {Name}");
            
            if (_items.Count == 0) //for empty batch
            {
                Console.WriteLine("Empty Order.");
                Console.WriteLine();
            }
            else
            {
                foreach (Thing i in _items)
                {
                    i.Print();
                }
                Console.WriteLine($"Total: ${Total()}");
                Console.WriteLine();
            }



        }



        public override decimal Total()
		{
			decimal totalSum = 0;
			foreach(Thing i in _items)
			{
				totalSum = totalSum + i.Total();
			}
			return totalSum;
		}


		


	}
}

