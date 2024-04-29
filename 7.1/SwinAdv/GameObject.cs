using System;
namespace SwinAdv
{
	public class GameObject : IdentifiableObject
	{
		private string _description;
		private string _name;

		public GameObject(string[] ids , string name ,string desc) : base(ids)
		{
			_name = name;
			_description = desc;
		}
		public string Name
		{
			get
			{
				return _name;
			}
		}

		public string ShortDescription
		{
			get
			{
				return $"{_name} ({FirstId})";
			}

		}
		virtual public string FullDescription
		{
			get
			{
				return _description;
			}
		}
	}
}

