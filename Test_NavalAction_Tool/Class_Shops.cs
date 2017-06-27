using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_NavalAction_Tool
{
    public class Shop
    {
        public DateTime Created { get; set; }
        public int Id { get; set; }
        public DateTime Modified { get; set; }
        public Regularitem[] RegularItems { get; set; }
        public Resourcesadded[] ResourcesAdded { get; set; }
        public Resourcesconsumed[] ResourcesConsumed { get; set; }
        public Resourcesproduced[] ResourcesProduced { get; set; }
    }

    public class Regularitem
    {
        public int TemplateId { get; set; }
        public int Quantity { get; set; }
        public int SellPrice { get; set; }
        public int BuyPrice { get; set; }
        public int BuyContractQuantity { get; set; }
        public int SellContractQuantity { get; set; }
    }

    public class Resourcesadded
    {
        public int Key { get; set; }
        public Values Value { get; set; }
    }

    public class Values
    {
        public int Key { get; set; }
        public float Value { get; set; }
    }

    public class Resourcesconsumed
    {
        public int Key { get; set; }
        public int Value { get; set; }
    }

    public class Resourcesproduced
    {
        public int Key { get; set; }
        public int Value { get; set; }
    }

}
