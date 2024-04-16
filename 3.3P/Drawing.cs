using System;
using System.Linq;
using System.Collections.Generic;
using SplashKitSDK;
using ShapeDrawer;

//104817068
namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this(Color.LightGreen)
        {

        }

        

        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

        
        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape()
        {
            foreach (Shape s in _shapes.ToList())
            {
                if (s.Selected)
                {
                    _shapes.Remove(s);
                }

            }

        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach(Shape s in _shapes)
            {
                s.Draw();
            }
        }


        public void SelectedShapeAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }
            }
        }

       


        //selectedshape property

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>(); // Create a new list to store selected shapes
                                                        // Iterate through each shape in _shapes
                foreach (Shape s in _shapes)
                {
                    // Check if the shape is selected
                    if (s.Selected)
                    {
                        // If selected, add it to the result list
                        result.Add(s);
                    }
                }

                // Return the list of selected shapes
                return result;
            }
        }


        




    }
}