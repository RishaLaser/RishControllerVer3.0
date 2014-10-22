using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint
{
    public class ColorCode
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private Color _Ccolor;

        public Color Ccolor
        {
            get { return _Ccolor; }
            set { _Ccolor = value; }
        }
        private int _power;

        public int Power
        {
            get { return _power; }
            set { _power = value; }
        }

        public static string GetPowerString(int num)
        {
            string strResult = string.Empty;

            if (num == 100)
                strResult = "100";
            else if (num >= 10)
                strResult = "0" + num;
            else
                strResult = "00" + num;

            return strResult;
        }
        public string PowerString
        {
            get
            {
                return GetPowerString(_power);
            }
        }



        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public enum ColorType {Raster,Vector};

        private ColorType _type;

        public ColorType Type
        {
            get { return _type; }
            set { _type = value; }
        }


        public string GCode
        {
            get;
            set;
        }


    }
}
