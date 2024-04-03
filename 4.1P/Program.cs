using System;
using SplashKitSDK;
//104817068
namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            Drawing myDrawing = new Drawing();
            ShapeKind kindToAdd =  ShapeKind.Circle;
            
            Window window = new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if(SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }

                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }


                if(SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }
                

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    if(kindToAdd == ShapeKind.Rectangle)
                    {
                        MyRectangle ShapeDrawn = new MyRectangle();
                     
                        ShapeDrawn.X = SplashKit.MouseX();
                        ShapeDrawn.Y = SplashKit.MouseY();
                        myDrawing.AddShape(ShapeDrawn);

                    }

                    else if (kindToAdd == ShapeKind.Circle)
                    {
                        MyCircle ShapeDrawn = new MyCircle();

                        ShapeDrawn.X = SplashKit.MouseX();
                        ShapeDrawn.Y = SplashKit.MouseY();
                        myDrawing.AddShape(ShapeDrawn);

                    }
                    else
                    {
                       MyLine ShapeDrawn = new MyLine();

                        ShapeDrawn.X = SplashKit.MouseX();
                        ShapeDrawn.Y = SplashKit.MouseY();
                        myDrawing.AddShape(ShapeDrawn);
                    }


                }

                //if right butto n is clicked
                
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myDrawing.SelectedShapeAt(SplashKit.MousePosition());
                }


                //if presssed spacebar

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                    Console.WriteLine("SpaceKey");
                }

                if(SplashKit.KeyTyped(KeyCode.DeleteKey) || (SplashKit.KeyTyped(KeyCode.BackspaceKey)))
                {
                    myDrawing.RemoveShape();
                }

                myDrawing.Draw();

                SplashKit.RefreshScreen();

            }
            while (!SplashKit.WindowCloseRequested("Shape Drawer"));

        }
    }
}
