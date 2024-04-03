using System;
using SplashKitSDK;

namespace ShapeDrawer
{
	public class MyCircle : Shape
	{
		private int _radius;
        public MyCircle() : this(Color.Blue, 0, 0, 50)
		{

		}

        public MyCircle(Color clr, float x,float y,int radius) : base(clr)
		{
			X = x;
			Y = y;
			_radius = radius;
		}

		

		public int Radius
		{
			get
			{
				return _radius;
			}
			set
			{
				_radius = value;
			}
		}

        public override void Draw()
        {
           if(Selected)
			{
				DrawOutline();
			}
			SplashKit.FillCircle(Color, X, Y, _radius);
        }

        //draws a black circle with a radius 2px larger than radius

        public override void DrawOutline()
        {
            //base.DrawOutline();
            SplashKit.FillCircle(Color.Black, X , Y , _radius +2 );

        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointInCircle(pt, SplashKit.CircleAt( X , Y , _radius));

        }

    }
}

