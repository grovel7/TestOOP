using System;
namespace SwinAdv
{
	public class Location : GameObject,IHaveInventory
	{
		private string _name, _desc;
		Inventory _inventory = new Inventory();
		public Location(string name , string desc) : base(new string[] {"location"} , name , desc)
		{
			 _name = name;
			_desc = desc;

		}

		public GameObject Locate(string id)
		{
			if(AreYou(id))
			{
				return this;
			}
			return _inventory.Fetch(id);
		}

        public override string FullDescription
		{
			get
			{

			}
		}
    }
}

