using System;
using SplashKitSDK;


namespace ShapeDrawer
{
	public class MyLine : Shape
	{
        private float _endX, _endY;
       private  int _length;
		public MyLine() : this(Color.Red,0,0,100)
		{
		}

        public MyLine(Color clr , float x,float y , int length) : base(clr)
        {
            X = x;
            Y = y;
            Length = length;
        }


        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }


        public float EndX
        {
            get
            {
                return _endX;
            }

            set
            {

                _endX = value;
            }

        }



        public float EndY
        {
            get
            {
                return _endY;
            }

            set
            {

                _endY = value;
            }

        }


        public override void Draw()
        {
            if(Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(Color, X, Y,X+ Length, Y);
        }

        public override void DrawOutline()
        {
            //small circle in the beginning
            int circleRadius = 3;
            SplashKit.FillCircle(Color.Black, X, Y, circleRadius);
            SplashKit.FillCircle(Color.Black , X+Length , Y , circleRadius);
        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, X + Length, Y));
        }
    }
}

