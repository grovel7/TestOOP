using System;
using SplashKitSDK;
//104817068
namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Drawing myDrawing = new Drawing();

            
            Window window = new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                //check if the left button is clicked


                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    int x_pos = (int)SplashKit.MouseX();
                    int y_pos = (int)SplashKit.MouseY();
                    myDrawing.AddShape(new Shape(x_pos, y_pos));
                }

                //if right butto n is clicked

                if(SplashKit.MouseClicked(MouseButton.RightButton))
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
