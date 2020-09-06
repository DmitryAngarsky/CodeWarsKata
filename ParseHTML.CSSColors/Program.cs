using System;
using System.Collections.Generic;
using System.Linq;

namespace ParseHTML.CSSColors
{
    class HtmlColorParser
    {
        private readonly IDictionary<string, string> presetColors;

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public HtmlColorParser(IDictionary<string, string> presetColors)
        {
            this.presetColors = presetColors;
        }

        public RGB Parse(string color)
        {
            if (color.First() == '#')
            {
                color = color.Remove(0, 1);
                if (color.Length == 3)
                {
                    color = string.Concat(color.Select(x => x.ToString() + x.ToString()));
                }
            }
            else
            {
                var keyValuePair = presetColors.Single(x => x.Key == color.ToLower());
                color = keyValuePair.Value.Remove(0, 1);
            }
            
            byte[] rgbMap = StringToByteArray(color);

            return new RGB(rgbMap[0], rgbMap[1], rgbMap[2]);
        }
    }

    struct RGB
    {
        public byte r, g, b;
        public RGB(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            string test = "#80FFA0";

            HtmlColorParser parser = new HtmlColorParser(openWith);
            var rgbStr = parser.Parse(test);
            Console.WriteLine($"{rgbStr.r} {rgbStr.g} {rgbStr.b}");
            //Console.WriteLine(string.Concat(test1.Select));
            Console.ReadKey();
        }
    }
    
}
