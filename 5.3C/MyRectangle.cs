using System;
using SplashKitSDK;
using System.IO;

namespace ShapeDrawer
{
	public class MyRectangle : Shape
	{
        private int _width, _height;


        public MyRectangle() : this(Color.Green , 0 ,0,100,100)
        {

        }


        public MyRectangle(Color clr , float x, float y, int width , int height) : base(clr)
        {
            //_width = width;
            //_height = height;

            Width = width;
            Height = height;
            X = x;
            Y = y;
            
        }

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }

        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillRectangle(Color, X, Y, Width, Height);
        }

        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, X - 2, Y - 2, Width + 4, Height + 4);

        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(X, Y, Width, Height));

        }


        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Rectangle");
            base.SaveTo(writer);
            writer.WriteLine(Width);
            writer.WriteLine(Height);

        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            Width = reader.ReadInteger();
            Height = reader.ReadInteger();

        }


    }

}

