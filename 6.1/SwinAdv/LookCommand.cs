using System;
namespace SwinAdv
{
	public class LookCommand : Command
	{
		public LookCommand() : base(new string[] {"look"})
		{
		}


		public override string Execute(Player p , string[] text)
		{
			IHaveInventory container;

			if (text[0] == "look")
			{

			}


		}

		private IHaveInventory FetchContainer( Player p ,string containerId)
		{
			return 
		}


		private string LookAtIn(string thingId , IHaveInventory container)
		{
			if(container.Locate(thingId) == null )
			{
				return $"i cannot find the {thingId}";
			}
			else
			{
				return container.Locate(thingId).FullDescription;
			}
		}
	}
}

