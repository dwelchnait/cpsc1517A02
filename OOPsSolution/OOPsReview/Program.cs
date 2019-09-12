using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //assume that you know how to do data input into
            //   a console application (CPSC1012)
            //the input data will simply be placed in a local variable
            //linearlength
            double linearlength = 135.0;
            //height
            double height = 6.5;
            //width
            double width = 8.0;
            //style
            string style = "Neighbour friendly: Spruce";
            double price = 108.00;

            //situation: have the required data for the class instance
            //options a) create instance using default constructor AND
            //           multiple assignment statements
            //        b) create instance using greedie constructor
            //solution: b) one statement

            //FencePanel is a non-static class
            //Console was a static class (DOES NOT store data)
            //for a non-static class, you MUST create an instance of the class
            //     to be able to use the class
            //syntax using the new keyword which requires a reference to the
            //     appropriate class constructor
            FencePanel panel = new FencePanel(height, width, style, price);

            //handle numerious gates
            //create a class pointer able to reference the Gate class
            //this pointer will be null
            Gate gateinfo;

            //a structure to hold a collection of Gate
            //the stucture to use should hold an unknown number of instances
            //structure will be a List<T>
            //create the new instance of the List<T> when it is defined
            List<Gate> gatelist = new List<Gate>();

            //assume you are in a loop to gather multiple gates


        }
    }
}