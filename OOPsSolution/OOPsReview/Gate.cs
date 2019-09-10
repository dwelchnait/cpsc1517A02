using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Gate
    {
        public double Height { get; set; }
        private string _Style;
        private double _Width;

        public string Style
        {
            get
            {
                return _Style;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Style = null;
                }
                else
                {
                    _Style = value;
                }
            }
        }

        public double Width
        {
            get
            {
                return _Width;
            }
            set
            {
                if (value > 0.0)
                {
                    new Exception("Width can not be 0 or less than 0.");
                }
                else
                {
                    _Width = value;
                }
            }
        }

        public double? Price { get; set; }
        public Gate()
        {

        }
        public Gate(double height, double width, string style, double? price)
        {
            Height = height;
            Width = width;
            Price = price;
            Style = style;
        }
        public double GateArea()
        {
            //property Heights is auto implemented, there is no choice
            return Width * Height;
        }
    }
}
