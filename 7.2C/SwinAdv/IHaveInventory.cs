using System;
namespace SwinAdv
{
	public interface IHaveInventory
	{
		GameObject Locate(string id);

		string Name //readonly property
		{
			get
			{
				return Name;
			}
		}
	}
}

