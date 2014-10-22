using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    public class Shape
    {
        public Point Location;          //position of the point
        public float Width;             //width of the line
        public Color Colour;            //colour of the line
        public int ShapeNumber;         //part of which shape it belongs to

        //CONSTRUCTOR
        public Shape(Point L, float W, Color C, int S)
        {
            Location = L;               //Stores the Location
            Width = W;                  //Stores the width
            Colour = C;                 //Stores the colour
            ShapeNumber = S;            //Stores the shape number
        }
    }
}
