using System;
using SplashKitSDK;
using System.IO;
//104817068
namespace ShapeDrawer
{
	public abstract class Shape
	{

        private Color _color;
        private float _x;
        private float _y;
        //private int _width;
        //private int _height;

		private bool _selected;
		//constructor

		public Shape() : this(Color.Yellow)
		{

		}
        public Shape(Color clr)
		{
			_x = 0.0f;
			_y = 0.0f;
			_color = clr;
			
			 
		}
		//property
		public Color Color
		{
			get
			{
				return _color;
			}
			set
			{
				_color = value;
			}
		}
		public float X
		{
			get
			{
				return _x;
			}
			set
			{
				_x = value;
			}

		}
		public float Y
		{
			get
			{
				return _y;
			}
			set
			{
				_y = value;
			}
		}

        public bool Selected
		{ get
			{
				return _selected;
			}
			set
			{
				_selected = value;
			}
		}



		public abstract void Draw();

		public abstract bool IsAt(Point2D pt); 
		
		public abstract void DrawOutline();



		//saveTo method
		//virtual method

		public virtual void SaveTo(StreamWriter writer)
		{
			writer.WriteColor(Color);
			writer.WriteLine(X);
			writer.WriteLine(Y);
		}

		//loadfrom

		public virtual void LoadFrom(StreamReader reader)
		{
			Color = reader.ReadColor();
			X = reader.ReadInteger();
			Y = reader.ReadInteger();
		}
        



    }
}

