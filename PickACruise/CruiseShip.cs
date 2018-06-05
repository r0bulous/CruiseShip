using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACruise
{
    class CruiseShip : Travel
    {
        public CruiseShip()
        {
            //default constructor
        }

        public CruiseShip(int num)
        {
            this.Value = num;
        }

        public string GetCruiseShip()
        {
            switch (CustAge())
            {
                case 1:
                    ReturnValue = "Norweigen";
                    return ReturnValue;
                case 2:
                    ReturnValue = "Princess";
                    return ReturnValue;
                case 3:
                    ReturnValue = "the Alaska Marine Highway System";
                    return ReturnValue;
                case 4:
                    ReturnValue = "Disney";
                    return ReturnValue;
                case 5:
                    ReturnValue = "Phillips 26 Glacier Cruise";
                    return ReturnValue;
                default:
                    ReturnValue = "a shrimp boat";
                    return ReturnValue;
            }
        }
    }
}

