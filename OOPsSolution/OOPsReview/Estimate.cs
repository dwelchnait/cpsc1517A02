using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Estimate
    {
        //
        public double TotalPrice { get; private set; }
        public double LinearLength { get; set; }

        public FencePanel Panel{get;set; }

        public List<Gate> Gates { get; set; }

        public double CalculatePrice()
        {
            //using properties of FencePanel
            double numberofpanels = Panel.EstimatedNumberOfPanels(LinearLength);
            if ((int)(numberofpanels * 10.0) > ((int)numberofpanels * 10))
            {
                numberofpanels++;
            }
            //summing calculated prices
            if (Panel.Price == null)
            {
                throw new Exception("Panel price is needed to create estimate");
            }
            else
            {
                
                TotalPrice += numberofpanels * (double)Panel.Price;
                foreach(var item in Gates)
                {
                    TotalPrice += item.Price;
                }
            }
             return TotalPrice;
        }
    }
}
