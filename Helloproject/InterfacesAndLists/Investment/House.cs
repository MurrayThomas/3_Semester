using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndLists.Investment
{
    public class House
    {

        // Constructor
        public House(string inAddress, int inSquareMeters, int inSquareMeterPrice, string inCondition, string inDescription)
        {
            Address = inAddress;
            SquareMeters = inSquareMeters;
            SquareMeterPrice = inSquareMeterPrice;
            Condition = inCondition;
            Description = inDescription;
        }

        /* Properties */
        public string Address { get; set; }
        public int SquareMeters { get; set; }
        public int SquareMeterPrice { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }

        /* Methods */
        public int PriceCalculate()
        {
            int foundPrice = SquareMeters * SquareMeterPrice;
            return foundPrice;
        }

        public string InvestSummary()
        {
            string summ = "House: " + Address + Environment.NewLine + "Area = " + SquareMeters;
            summ += Environment.NewLine + "Price: " + PriceCalculate();
            return summ;


        }
    }
}
