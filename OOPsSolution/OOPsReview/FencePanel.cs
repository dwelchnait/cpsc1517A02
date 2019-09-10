using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    //the default permissions is private
    //if an outside user of this class wanted
    //  access to the class contents; then the
    //  class permissions must be public
    public class FencePanel
    {
        //Properties
        //property is associated with a single piece of data
        //property has two sub components
        //    get: returns a value to the calling agent
        //    set: receives a value from the calling agent
        //         the keyword use to represent the  incoming data
        //         is value
        //a property DOES NOT have a developer's parameter

        //two ways to code a property
        //Auto-Implemented
        //  a private data member DOES NOT need to be coded
        //  the system will create an internal data member that
        //      the sytem will manage
        public double Height { get; set; }
        //public double Width { get; set; }

        //Fully Implemented
        //  a private data member WILL be coded for use by this property
        //  typically the incoming data needs additional processing
        //     such as validation
        //  Exaample: the characteristic is a string that can be null or
        //            requires at least on character (that is the string
        //            can not be empty)

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
                if (value <= 0.0)
                {
                    new Exception("Width can not be 0 or less than 0.");
                }
                else
                {
                    _Width = value;
                }
            }
        }

        //Does a nullable non-string data value need a fully-Implemented
        //    property?
        //NO. a nullable numeric will either be given a numeric value OR null;
        //However: if the numeric needs additional checking then you should
        //         consider using a fully-implemented property
        public double? Price { get; set; }

        //Constructors

        //default
        public FencePanel()
        {

        }

        //greedy
        //list of parameters representing each possible data value in your
        //   class (properties)
        public FencePanel(double height, double width, string style, double? price)
        {
            Height = height;
            Width = width;
            Price = price;
            Style = style;
        }

        //Behaviours
        //a.k.a. a method
        public double EstimatedNumberOfPanels(double linearlength)
        {
            //you could use either the property Width OR the private data
            //    member _Width
            //Using the property ensures all validation or excess logic
            //    is in play
            double numberofpanels = linearlength / _Width; 
            return numberofpanels;
        }

        public double FenceArea(double linearlength)
        {
            //property Heights is auto implemented, there is no choice
            return linearlength * Height;
        }
    }
}
