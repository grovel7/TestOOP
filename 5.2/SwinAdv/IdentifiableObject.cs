using System;
namespace SwinAdv
{
	public class IdentifiableObject
	{
		private List<string> _identifiers; //list is same as array but without limit; can change size dynamically

		//constructor

		public IdentifiableObject(string[] idents)
		{
			_identifiers = new List<string>();
			//adds identifiers from the passed array
			for(int i = 0; i <idents.Length;i++)
			{
				_identifiers.Add(idents[i]); 
			}

		}

		public bool AreYou(string id)
		{
			//checks if the passed in identifier is in the _identifier
			return _identifiers.Contains(id.ToLower());

		}

		//property ; readonly
		public string FirstId
		{
			get
			{
				if(_identifiers.Count == 0)
				{
					return "";
				}
				else
				{
					return _identifiers.First();
				}

			}
		}

		

		public void AddIdentifier(string id)
		{
			_identifiers.Add(id.ToLower());
		}
	}
}

