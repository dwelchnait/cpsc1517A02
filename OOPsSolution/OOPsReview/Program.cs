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
            //assume that fence data is queried from the user
            // user entered linearlength
            double linearlength = 135.0;
            // user entered height
            double height = 6.5;
            // user entered width
            double width = 8.0;
            // user entered style
            string style = "Neighbour friendly : Spruce";
            // user entered price/panel
            double price = 108.00;

            FencePanel panelInfo = new FencePanel(height, width, style, price);

            
            Gate gateInfo;
            List<Gate> gateList = new List<Gate>();

            // loop to get gate data
            // assume 2 gates are going to be entered
            // on each loop
            gateInfo = new Gate();
            height = 6.25;
            width = 4.0;
            style = "Neighbour friendly - 1/2 picket : Spruce";
            price = 86.45;
            gateInfo.Height = height;
            gateInfo.Width = width;
            gateInfo.Style = style;
            gateInfo.Price = price;
            gateList.Add(gateInfo);

            //or
           
            height = 6.25;
            width = 3.0;
            style = "Neighbour friendly : Spruce";
            price = 72.45;
            gateInfo = new Gate(height,width,style,price);
            gateList.Add(gateInfo);

            //end of loop

            //create estimate
            Estimate clientEstimate = new Estimate();
            clientEstimate.LinearLength = linearlength;
            clientEstimate.Panel = panelInfo;
            clientEstimate.Gates = gateList;
            clientEstimate.CalculatePrice();

            // client requests a printout
            Console.WriteLine("The fence is be a " + clientEstimate.Panel.Style + " style.");
            Console.WriteLine("Total linear length requested {0}", clientEstimate.LinearLength);
            Console.WriteLine("Number of Panels {0}",
                clientEstimate.Panel.EstimatedNumberOfPanels(clientEstimate.LinearLength));
            Console.WriteLine("Number of Gates {0}", clientEstimate.Gates.Count());
            double fenceArea = clientEstimate.Panel.FenceArea(clientEstimate.LinearLength);
            foreach(var item in clientEstimate.Gates)
            {
                fenceArea += item.GateArea();
            }
            Console.WriteLine(string.Format("Total fence surface area {0:0.00}", fenceArea * 2));
            Console.ReadKey();
        }
    }
}
