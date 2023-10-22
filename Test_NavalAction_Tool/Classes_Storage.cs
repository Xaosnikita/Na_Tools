using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_NavalAction_Tool
{
    public class Storage
    {
        public Storage_Resources[] Storage_Resources { get; set; }

        public Storage_Materials[] Storage_Materials { get; set; }

        public Storage_LabourHours[] Storage_LabourHours { get; set; }

        public Storage_Ship_Recipes[] Storage_Ship_Recipes { get; set; }
    }

    public class Storage_LabourHours
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }
    }

    public class Storage_Materials
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public int BasePrice { get; set; }

        public double ItemWeight { get; set; }

        public int Id { get; set; }
    }

    public class Storage_Resources
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public int BasePrice { get; set; }

        public double ItemWeight { get; set; }

        public int AutoFillPrice { get; set; }

        public int Id { get; set; }

        public int ProducedByNation { get; set; }
    }

    public class Storage_Ship_Recipes
    {
        public string Name { get; set; }

        public bool Checked { get; set; }
    }

}
