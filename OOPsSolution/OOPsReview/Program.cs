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

            //1st gate
            //technique 1
            //create instance of Gate
            //collect data
            //add to List
            gateinfo = new Gate();
            height = 6.25;
            width = 4.0;
            style = "Neighbour friendly - 1/2 picket: spruce";
            price = 86.45;
            gateinfo.Height = height;
            gateinfo.Width = width;
            gateinfo.Style = style;
            gateinfo.Price = price;
            gatelist.Add(gateinfo);

            //2nd gate
            //technique 2
            //collect data
            //create the Gate instance
            //add to list
            height = 6.25;
            width = 3.0;
            style = "Neighbour friendly: spruce";
            price = 72.45;
            gateinfo = new Gate(height, width, style, price);
            gatelist.Add(gateinfo);


            //create the Estimate
            Estimate ClientEstimate = new Estimate();  //system default
            ClientEstimate.LinearLength = linearlength;
            ClientEstimate.Panel = panel;
            ClientEstimate.Gates = gatelist;
            ClientEstimate.CalculatePrice();

            //ouptut client information
            Console.WriteLine("The fence is to be a " + ClientEstimate.Panel.Style + " style");
            Console.WriteLine("the linear fence length required is {0:0.0}", ClientEstimate.LinearLength);
            Console.WriteLine("Number of required panels {0}",
                ClientEstimate.Panel.EstimatedNumberOfPanels(ClientEstimate.LinearLength));
            Console.WriteLine("NUmber of required gates {0}", ClientEstimate.Gates.Count);
            double fenceArea = ClientEstimate.Panel.FenceArea(ClientEstimate.LinearLength);
            foreach(var item in ClientEstimate.Gates)
            {
                fenceArea += item.GateArea();
            }
            Console.WriteLine(string.Format("Total fence surface area {0:0.00}", fenceArea * 2));
            Console.ReadKey(); //required due to using just F5

        }
    }
}