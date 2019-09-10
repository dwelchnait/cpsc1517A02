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
                    _Width = value;
                }
                else
                {
                    new Exception("Width can not be 0 or less than 0.");
                }
            }
        }
        private double _Price;
        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (value > 0.0)
                {
                    _Price = value;
                }
                else
                {
                    new Exception("Price can not be 0 or less than 0.");
                }
            }
        }
        public Gate()
        {

        }
        public Gate(double height, double width, string style, double price)
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
