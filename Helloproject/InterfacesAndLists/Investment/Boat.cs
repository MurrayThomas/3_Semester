using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndLists.Investment
{
    public class Boat
    {

        // Constructor
        public Boat(int inLength, int inMeterPrice, string inCondition, string inDescription, int inRegYear)
        {
            Length = inLength;
            MeterPrice = inMeterPrice;
            Condition = inCondition;
            Description = inDescription;
            RegYear = inRegYear;
        }

        /* Properties */
        public int Length { get; set; }
        public int MeterPrice { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public int RegYear { get; set; }

        /* Methods */
        public int CalculatePrice()
        {
            int foundPrice = Length * MeterPrice;
            return foundPrice;
        }

        public string InvestSummary()
        {
            string summ = "Boat: " + Description + Environment.NewLine + "Length " + Length;
            summ += Environment.NewLine + "Price: " + CalculatePrice();
            return summ;
        }
    }

}
