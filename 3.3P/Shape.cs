using System;
using SplashKitSDK;
//104817068
namespace ShapeDrawer
{
	public class Shape
	{

        private Color _color;
        private float _x;
        private float _y;
        private int _width;
        private int _height;

		private bool _selected;
        //constructor
        public Shape(int x , int y)
		{
			_color = Color.RandomRGB(500);
			_x = x;
			_y = y;
			
			_width = _height = 100;
			 
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


        

        public void Draw()
		{
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);

			
		}
		public bool IsAt(Point2D pt)
		{
			return SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(X, Y, _width, _height));
			
						
		}


        public void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
        }




    }
}

