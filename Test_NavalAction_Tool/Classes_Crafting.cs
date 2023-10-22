using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_NavalAction_Tool
{
    public class CR_Fullrequirement
    {
        public string Name { get; set; }

        public int Amount { get; set; }

        public int Template { get; set; }

        public int Chance { get; set; }
    }

    public class CR_Result
    {
        public string Name { get; set; }

        public int Amount { get; set; }

        public int Template { get; set; }

        public float Chance { get; set; }
    }

    public class Craft_Order
    {
        public int Type { get; set; }

        public string Name { get; set; }

        public int Woodtype { get; set; }

        public int Quality { get; set; }

        public int Trim { get; set; }
    }

    public class Craft_Recipe
    {
        public string Name { get; set; }

        public int Flag { get; set; }

        public int LaborPrice { get; set; }

        public int Id { get; set; }

        public CR_Fullrequirement[] CR_Fullrequirement { get; set; }

        public CR_Result[] CR_Result { get; set; }

        public int RequiresLevel { get; set; }

        public int GivesXP { get; set; }
    }

}