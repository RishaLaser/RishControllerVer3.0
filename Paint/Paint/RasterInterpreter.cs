using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Paint;

namespace Paint
{
    public class RasterInterpreter
    {
        const string RIGHT_FAST = "1";
        const string RIGHT_SLOW = "2";
        const string LEFT_FAST = "3";
        const string LEFT_SLOW = "4";
        const string UP_FAST = "5";
        const string UP_SLOW = "6";
        const string DOWN_FAST = "7";
        const string DOWN_SLOW = "8";
        const string LASER_ON = "9";
        const string LASER_OFF = "0";
        const string RETURN = "r";


        const int BUFFER_SIZE = 30;
        //fields
        private Bitmap _image = null;

        //Properties
        public Bitmap Image
        {
            get { return _image; }
            set { _image = value; }
        }

        bool m_bPowerDependsOnGrayScale;

        public RasterInterpreter(bool p_bPowerDependsOnGrayScale)
        {
            m_bPowerDependsOnGrayScale = p_bPowerDependsOnGrayScale;
        }

        //Functions
        public string Convert(Bitmap img,List<ColorCode> Colors)
        {
            string[,] burnpixels;
            List<int> starts;
            List<int> ends;
            StringBuilder outputarray;

            GetImageArray(img, Colors, out burnpixels, out starts, out ends, out outputarray);

            System.IO.File.WriteAllText(@"imagearray.txt", outputarray.ToString());

            return ConvertToRasterCode(burnpixels, starts, ends);
        }

        private void GetImageArray(Bitmap img, List<ColorCode> Colors, out string[,] burnpixels, out List<int> starts, out List<int> ends, out StringBuilder outputarray)
        {
            int[,] imagarray = new int[MainForm.IMAGE_LENGTH, MainForm.IMAGE_WIDTH];
            burnpixels = new string[MainForm.IMAGE_LENGTH, MainForm.IMAGE_WIDTH];
            starts = new List<int>();
            ends = new List<int>();
            bool hasdata = false;
            bool detected = false;

            outputarray = new StringBuilder();


            for (int y = 1; y < img.Height - 1; y++)
            {
                int end = 0;
                for (int x = 1; x < img.Width - 1; x++)
                {
                    Color p = img.GetPixel(x, y);
                    //if (p.R != 255 || p.G != 255 || p.B != 255)
                    foreach (ColorCode cc in Colors)
                    {
                        if (p.ToArgb() == cc.Ccolor.ToArgb() 
                            || ( m_bPowerDependsOnGrayScale && p.ToArgb() != Color.White.ToArgb()) ) //Consider any color except White
                        {

                            imagarray[x, y] = new int();
                            imagarray[x, y] = 1;
                            //outputfile += "1";
                            outputarray.Append("1");
                            //burnpixels[x, y] = new int();

                            string power = "050";

                            if (m_bPowerDependsOnGrayScale)
                                power = p.PowerString_GrayScale();
                            else
                                power = cc.PowerString;

                            burnpixels[x, y] = power;
                            //Console.WriteLine(string.Format("1-burnpixels[{0},{1}] = {2}", x, y, cc.PowerString));
                            if (!hasdata)
                            {
                                hasdata = true;
                                starts.Add(x);
                            }

                            end = x;
                            detected = true;

                            //No need to iterate for other ColorCodes
                            break;
                            
                        }

                    }

                    if (!detected)
                    {
                        imagarray[x, y] = new int();
                        imagarray[x, y] = 0;
                        //outputfile += "0";
                        outputarray.Append("0");
                        burnpixels[x, y] = null;
                    }
                    detected = false;
                }
                if (!hasdata)
                {
                    starts.Add(0);
                }
                ends.Add(end);
                hasdata = false;
                //outputfile += System.Environment.NewLine;
                outputarray.AppendLine();
            }
        }

        private string ConvertToRasterCode(string[,] burnpixels, List<int> starts, List<int> ends)
        {
            string outputfile = "";
            StringBuilder buffer = new StringBuilder();
            int i = 1;
            while (i < (MainForm.IMAGE_WIDTH - 1))
            {
                //left to right
                int k = 1;
                if (starts[i] != 0)
                {
                    if (starts[i] > starts[i - 1])
                    {
                        int length = starts[i] - starts[i - 1];
                        for (int u = 0; u < length; u++)
                        {
                            //buffer.Append("01");
                            buffer.Append(LASER_OFF + RIGHT_FAST);
                            if (k == BUFFER_SIZE)
                            {
                                buffer.Append(",");

                                k = 1;
                            }
                            k++;
                        }

                    }


                    for (int j = starts[i]; j <= ends[i]; j++)
                    {

                        if (burnpixels[j, i] != null)
                        {
                            //buffer.Append("92");
                            //Console.WriteLine(string.Format("burnpixels[{0},{1}] = {2}",j,i,burnpixels[j, i].ToString()));
                            buffer.Append(LASER_ON + burnpixels[j, i] + RIGHT_SLOW);
                        }
                        else
                        {
                            //buffer.Append("01");
                            buffer.Append(LASER_OFF + RIGHT_FAST);
                        }

                        if (k == BUFFER_SIZE)
                        {
                            buffer.Append(",");
                            k = 1;
                        }
                        k++;
                    }
                    if (ends[i + 1] > ends[i])
                    {
                        int length = ends[i + 1] - ends[i];
                        for (int u = 0; u < length; u++)
                        {
                            //buffer.Append("01");
                            buffer.Append(LASER_OFF + RIGHT_FAST);
                            if (k == BUFFER_SIZE)
                            {
                                buffer.Append(",");
                                k = 1;
                            }
                            k++;
                        }

                    }
                    i++;
                    //buffer.Append("0,5");
                    buffer.Append(LASER_OFF +"," + UP_FAST);
                    //right to left
                    k = 1;
                    if (ends[i] < ends[i - 1])
                    {
                        int length = ends[i - 1] - ends[i];
                        for (int u = 0; u < length; u++)
                        {
                            //buffer.Append("03");
                            buffer.Append(LASER_OFF + LEFT_FAST);
                            if (k == BUFFER_SIZE)
                            {
                                buffer.Append(",");
                                k = 1;
                            }
                            k++;
                        }
                    }
                    for (int j = ends[i]; j >= starts[i]; j--)
                    {
                        if (burnpixels[j, i] != null)
                        {
                            //buffer.Append("94");
                            //Console.WriteLine(string.Format("burnpixels[{0},{1}] = {2}", j, i, burnpixels[j, i].ToString()));
                            buffer.Append(LASER_ON + burnpixels[j, i] + LEFT_SLOW);
                        }
                        else
                        {
                            //buffer.Append("03");
                            buffer.Append(LASER_OFF + LEFT_FAST);
                        }
                        if (k == BUFFER_SIZE)
                        {
                            buffer.Append(",");
                            k = 1;
                        }
                        k++;
                    }
                    if (starts[i] < starts[i + 1])
                    {
                        int length = starts[i + 1] - starts[i];
                        for (int u = 0; u < length; u++)
                        {
                            //buffer.Append("03");
                            buffer.Append(LASER_OFF + LEFT_FAST);
                            if (k == BUFFER_SIZE)
                            {
                                buffer.Append(",");
                                k = 1;
                            }
                            k++;
                        }

                    }
                    i++;
                    //buffer.Append("0,5,");
                    buffer.Append(LASER_OFF + "," + UP_FAST + ",");
                    if (k == BUFFER_SIZE)
                    {
                        buffer.Append(",");
                        k = 1;
                    }
                    k++;
                }
                else
                {
                    //buffer.Append("5,");
                    buffer.Append(UP_FAST + ",");
                    i++;
                }
            }
            //buffer.Append(",r");
            buffer.Append( "," + RETURN);
            outputfile = buffer.ToString();


            return outputfile;
        }
    }
}


static class  ColorExtension
{
    public static string PowerString_GrayScale(this Color c)
    {
       
        float ratio = 100f / 256f;

        int grayscale = (c.R + c.G + c.B) / 3;

        //Normalize grayscale to get a power
        int power = 100 - (int)(grayscale * ratio);

        return ColorCode.GetPowerString(power);
        
    }


}
