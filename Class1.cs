using System;

namespace TV_Library
{
    public class TV
    {
        public string[] ParamsName()
        {
            string[] output = new string[8];
            output[0] = "width";
            output[1] = "height";
            output[2] = "diagonal";
            output[3] = "resolution";
            output[4] = "model name";
            output[5] = "manufacturer";
            output[6] = "price";
            output[7] = "weight";
            return output;
        }
        public struct s_Resolution
        {
            public int X_Res;
            public int Y_Res;
        }
        public struct s_TV_Desc
        {
            public int width;
            public int height;
            public float diagonal;
            public s_Resolution resolution;
            public string modelName;
            public string manufacturer;
            public float price;
            public float weight;
        }
        public TV(s_TV_Desc deviceDescription)
        {
            this.Description = deviceDescription;
        }   
        public override string ToString()
        {
            string output = string.Empty;

            output += "              Width: " + Description.width + "\r\n";
            output += "             Height: " + Description.height + "\r\n";
            output += "           Diagonal: " + Description.diagonal + "\r\n";
            output += "         Resolution: " + Description.resolution.X_Res + "x" + Description.resolution.Y_Res + "\r\n";
            output += "             Square: " + Description.width * Description.height + "\r\n";
            output += "         Model name: " + Description.modelName + "\r\n";
            output += "       Manufacturer: " + Description.manufacturer + "\r\n";
            output += "              Price: " + Description.price + "\r\n";
            output += "             Weight: " + Description.weight + "\r\n";

            return output;
        }
        public s_TV_Desc Description { get; set; }
    }
}
