using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_NavalAction_Tool
{

    public class Backdeckclasslimit
    {
        public Limitation1 Limitation1
        {
            get;
            set;
        }

        public Limitation2 Limitation2
        {
            get;
            set;
        }

        public Limitation3 Limitation3
        {
            get;
            set;
        }
    }

    public class BackDeckClassLimit
    {
        public Limitation1 Limitation1
        {
            get;
            set;
        }

        public Limitation2 Limitation2
        {
            get;
            set;
        }

        public Limitation3 Limitation3
        {
            get;
            set;
        }
    }

    public class Botcannonsvariant
    {
        public object[] References
        {
            get;
            set;
        }
    }

    public class Building
    {
        public string __type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public float ConsumedScale
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public int SellPriceCoefficient
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }

        public int LootTable
        {
            get;
            set;
        }

        public int RequiredPortResource
        {
            get;
            set;
        }

        public int BaseProduction
        {
            get;
            set;
        }

        public Level[] Levels
        {
            get;
            set;
        }

        public int LaborPrice
        {
            get;
            set;
        }

        public object[] BuildingRequirements
        {
            get;
            set;
        }

        public object[] FullRequirements
        {
            get;
            set;
        }

        public int GoldRequirements
        {
            get;
            set;
        }

        public object[] Results
        {
            get;
            set;
        }

        public string CraftGroup
        {
            get;
            set;
        }

        public int RequiresLevel
        {
            get;
            set;
        }

        public int GivesXP
        {
            get;
            set;
        }

        public bool AccessibleByLevel
        {
            get;
            set;
        }

        public int BreakUpRecipeSpawnChance
        {
            get;
            set;
        }

        public bool DisposeOnUse
        {
            get;
            set;
        }

        public bool CanBeUsedInPort
        {
            get;
            set;
        }

        public bool CanBeUsedInOpenWorld
        {
            get;
            set;
        }
    }

    public class Buildingrequirement
    {
        public int BuildingTemplate
        {
            get;
            set;
        }

        public int Level
        {
            get;
            set;
        }
    }

    public class Buyprice
    {
        public float x
        {
            get;
            set;
        }

        public float y
        {
            get;
            set;
        }
    }

    public class Buyprice_int
    {
        public int Min
        {
            get;
            set;
        }

        public int Max
        {
            get;
            set;
        }
    }

    public class Consumed
    {
        public Sellprice_int SellPrice
        {
            get;
            set;
        }

        public Buyprice_int BuyPrice
        {
            get;
            set;
        }
    }

    public class CR_Fullrequirement
    {
        public string Name
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public int Template
        {
            get;
            set;
        }

        public int Chance
        {
            get;
            set;
        }
    }

    public class CR_Result
    {
        public string Name
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public int Template
        {
            get;
            set;
        }

        public float Chance
        {
            get;
            set;
        }
    }

    public class Craft_Order
    {
        public int Type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Woodtype
        {
            get;
            set;
        }

        public int Quality
        {
            get;
            set;
        }

        public int Trim
        {
            get;
            set;
        }
    }

    public class Craft_Recipe
    {
        public string Name
        {
            get;
            set;
        }

        public int Flag
        {
            get;
            set;
        }

        public int LaborPrice
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public CR_Fullrequirement[] CR_Fullrequirement
        {
            get;
            set;
        }

        public CR_Result[] CR_Result
        {
            get;
            set;
        }

        public int RequiresLevel
        {
            get;
            set;
        }

        public int GivesXP
        {
            get;
            set;
        }
    }

    public class CrewRepairItem
    {
        public string __type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public float ConsumedScale
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public float SellPriceCoefficient
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public bool DisposeOnUse
        {
            get;
            set;
        }

        public bool CanBeUsedInPort
        {
            get;
            set;
        }

        public bool CanBeUsedInOpenWorld
        {
            get;
            set;
        }
    }

    public class Deckclasslimit
    {
        public Limitation1 Limitation1
        {
            get;
            set;
        }

        public Limitation2 Limitation2
        {
            get;
            set;
        }

        public Limitation3 Limitation3
        {
            get;
            set;
        }
    }

    public class Deliveryorderoptions
    {
        public bool Valid
        {
            get;
            set;
        }

        public int StockSizeCraftExperience
        {
            get;
            set;
        }

        public int StockSize
        {
            get;
            set;
        }
    }

    public class ExtraLaborHoursUsableItem
    {
        public string __type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public float ConsumedScale
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public float SellPriceCoefficient
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public bool DisposeOnUse
        {
            get;
            set;
        }

        public bool CanBeUsedInPort
        {
            get;
            set;
        }

        public bool CanBeUsedInOpenWorld
        {
            get;
            set;
        }
    }

    public class Frontdeckclasslimit
    {
        public Limitation1 Limitation1
        {
            get;
            set;
        }

        public Limitation2 Limitation2
        {
            get;
            set;
        }

        public Limitation3 Limitation3
        {
            get;
            set;
        }
    }

    public class FrontDeckClassLimit
    {
        public Limitation1 Limitation1
        {
            get;
            set;
        }

        public Limitation2 Limitation2
        {
            get;
            set;
        }

        public Limitation3 Limitation3
        {
            get;
            set;
        }
    }

    public class Fullrequirement
    {
        public int Template
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public int Chance
        {
            get;
            set;
        }
    }

    public class Fullstack
    {
        public Sellprice_int SellPrice
        {
            get;
            set;
        }

        public Buyprice_int BuyPrice
        {
            get;
            set;
        }
    }

    public class Healthinfo
    {
        public int LeftArmor
        {
            get;
            set;
        }

        public int RightArmor
        {
            get;
            set;
        }

        public int FrontArmor
        {
            get;
            set;
        }

        public int BackArmor
        {
            get;
            set;
        }

        public int Crew
        {
            get;
            set;
        }

        public int Sails
        {
            get;
            set;
        }

        public int Hull
        {
            get;
            set;
        }

        public int Pump
        {
            get;
            set;
        }

        public int Rudder
        {
            get;
            set;
        }

        public int Deck1
        {
            get;
            set;
        }

        public int Deck2
        {
            get;
            set;
        }

        public int Deck3
        {
            get;
            set;
        }

        public int Deck4
        {
            get;
            set;
        }
    }

    public class Level
    {
        public float LaborDiscount
        {
            get;
            set;
        }

        public float ProductionLevel
        {
            get;
            set;
        }

        public int MaxStorage
        {
            get;
            set;
        }

        public int UpgradePriceGold
        {
            get;
            set;
        }

        public object[] UpgradePriceMaterials
        {
            get;
            set;
        }
    }

    public class Limitation1
    {
        public int Min
        {
            get;
            set;
        }

        public int Max
        {
            get;
            set;
        }
    }

    public class Limitation2
    {
        public int Min
        {
            get;
            set;
        }

        public int Max
        {
            get;
            set;
        }
    }

    public class Limitation3
    {
        public int Min
        {
            get;
            set;
        }

        public int Max
        {
            get;
            set;
        }
    }

    public class Material
    {
        public string __type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public float ConsumedScale
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public float SellPriceCoefficient
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }
    }

    public class Modifier
    {
        public string Slot
        {
            get;
            set;
        }

        public string[] MappingIds
        {
            get;
            set;
        }

        public int Absolute
        {
            get;
            set;
        }

        public int Percentage
        {
            get;
            set;
        }
    }

    public class Module
    {
        public string __type
        {
            get;
            set;
        }

        public Modifier[] Modifiers
        {
            get;
            set;
        }

        public int scoreValue
        {
            get;
            set;
        }

        public string UsageType
        {
            get;
            set;
        }

        public int MaxItems
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public float ConsumedScale
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public float SellPriceCoefficient
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }

        public string ModuleType
        {
            get;
            set;
        }

        public int Limitation1_Value
        {
            get;
            set;
        }

        public int Limitation2_Value
        {
            get;
            set;
        }

        public int Limitation3_Value
        {
            get;
            set;
        }
    }

    public class MortarDeckClassLimit
    {
        public Limitation1 Limitation1
        {
            get;
            set;
        }

        public Limitation2 Limitation2
        {
            get;
            set;
        }

        public Limitation3 Limitation3
        {
            get;
            set;
        }
    }

    public class Portprices
    {
        public bool Valid
        {
            get;
            set;
        }

        public Produced Produced
        {
            get;
            set;
        }

        public Consumed Consumed
        {
            get;
            set;
        }

        public Regular Regular
        {
            get;
            set;
        }

        public int FullStackAmount
        {
            get;
            set;
        }

        public Fullstack FullStack
        {
            get;
            set;
        }

        public int RandomPct
        {
            get;
            set;
        }

        public int RangePct
        {
            get;
            set;
        }
    }

    public class Produced
    {
        public Sellprice_int SellPrice
        {
            get;
            set;
        }

        public Buyprice_int BuyPrice
        {
            get;
            set;
        }
    }

    public class QualityModule
    {
        public int RequiresLevel
        {
            get;
            set;
        }

        public Requirement[] Requirements
        {
            get;
            set;
        }

        public Result[] Results
        {
            get;
            set;
        }
    }

    public class QualityShip
    {
        public Requirement[] Requirements
        {
            get;
            set;
        }

        public int RequiresLevel
        {
            get;
            set;
        }

        public int MaxPermanentModules
        {
            get;
            set;
        }

        public int MaxUpgradeModules
        {
            get;
            set;
        }
    }

    public class Recipe
    {
        public string __type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public float ConsumedScale
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public float SellPriceCoefficient
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }

        public int LaborPrice
        {
            get;
            set;
        }

        public object[] BuildingRequirements
        {
            get;
            set;
        }

        public Fullrequirement[] FullRequirements
        {
            get;
            set;
        }

        public int GoldRequirements
        {
            get;
            set;
        }

        public Result[] Results
        {
            get;
            set;
        }

        public string CraftGroup
        {
            get;
            set;
        }

        public int RequiresLevel
        {
            get;
            set;
        }

        public int GivesXP
        {
            get;
            set;
        }

        public bool AccessibleByLevel
        {
            get;
            set;
        }

        public int BreakUpRecipeSpawnChance
        {
            get;
            set;
        }

        public bool DisposeOnUse
        {
            get;
            set;
        }

        public bool CanBeUsedInPort
        {
            get;
            set;
        }

        public bool CanBeUsedInOpenWorld
        {
            get;
            set;
        }
    }

    public class RecipeModule
    {
        public string __type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public float ConsumedScale
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public float SellPriceCoefficient
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }

        public QualityModule[] Qualities
        {
            get;
            set;
        }

        public int LaborPrice
        {
            get;
            set;
        }

        public object[] BuildingRequirements
        {
            get;
            set;
        }

        public Fullrequirement[] FullRequirements
        {
            get;
            set;
        }

        public int GoldRequirements
        {
            get;
            set;
        }

        public Result[] Results
        {
            get;
            set;
        }

        public string CraftGroup
        {
            get;
            set;
        }

        public int RequiresLevel
        {
            get;
            set;
        }

        public int GivesXP
        {
            get;
            set;
        }

        public bool AccessibleByLevel
        {
            get;
            set;
        }

        public int BreakUpRecipeSpawnChance
        {
            get;
            set;
        }

        public bool DisposeOnUse
        {
            get;
            set;
        }

        public bool CanBeUsedInPort
        {
            get;
            set;
        }

        public bool CanBeUsedInOpenWorld
        {
            get;
            set;
        }
    }

    public class RecipeResource
    {
        public string __type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public float ConsumedScale
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public float SellPriceCoefficient
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }

        public int LaborPrice
        {
            get;
            set;
        }

        public Buildingrequirement[] BuildingRequirements
        {
            get;
            set;
        }

        public object[] FullRequirements
        {
            get;
            set;
        }

        public int GoldRequirements
        {
            get;
            set;
        }

        public Result[] Results
        {
            get;
            set;
        }

        public string CraftGroup
        {
            get;
            set;
        }

        public int RequiresLevel
        {
            get;
            set;
        }

        public int GivesXP
        {
            get;
            set;
        }

        public bool AccessibleByLevel
        {
            get;
            set;
        }

        public int BreakUpRecipeSpawnChance
        {
            get;
            set;
        }

        public bool DisposeOnUse
        {
            get;
            set;
        }

        public bool CanBeUsedInPort
        {
            get;
            set;
        }

        public bool CanBeUsedInOpenWorld
        {
            get;
            set;
        }
    }

    public class RecipeShip
    {
        public string __type
        {
            get;
            set;
        }

        public bool AccessibleByLevel
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public float BreakUpRecipeSpawnChance
        {
            get;
            set;
        }

        public Buildingrequirement[] BuildingRequirements
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public bool CanBeUsedInOpenWorld
        {
            get;
            set;
        }

        public bool CanBeUsedInPort
        {
            get;
            set;
        }

        public float ConsumedScale
        {
            get;
            set;
        }

        public string CraftGroup
        {
            get;
            set;
        }

        public bool DisposeOnUse
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public Fullrequirement[] FullRequirements
        {
            get;
            set;
        }

        public int GivesXP
        {
            get;
            set;
        }

        public int GoldRequirements
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int LaborPrice
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public QualityShip[] Qualities
        {
            get;
            set;
        }

        public int RequiresLevel
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public Result[] Results
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public float SellPriceCoefficient
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public Woodtypedesc[] WoodTypeDescs
        {
            get;
            set;
        }
    }

    public class Regular
    {
        public Sellprice_int SellPrice
        {
            get;
            set;
        }

        public Buyprice_int BuyPrice
        {
            get;
            set;
        }
    }

    public class Repairkitcooldownmodifier
    {
        public float x
        {
            get;
            set;
        }

        public int y
        {
            get;
            set;
        }
    }

    public class Repairkitpricemodifier
    {
        public float x
        {
            get;
            set;
        }

        public float y
        {
            get;
            set;
        }
    }

    public class Repairkits
    {
        public int x
        {
            get;
            set;
        }

        public int y
        {
            get;
            set;
        }
    }

    public class Requirement
    {
        public int Template
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public int Chance
        {
            get;
            set;
        }
    }

    public class Resource
    {
        public string __type
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public int ConsumedScale
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public float SellPriceCoefficient
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }

        public int InitialAmount
        {
            get;
            set;
        }

        public float ProductionScale
        {
            get;
            set;
        }

        public int ConsumptionScale
        {
            get;
            set;
        }

        public int SpawnChance
        {
            get;
            set;
        }

        public int AutoFillCoefficient
        {
            get;
            set;
        }

        public int ProducedByNation
        {
            get;
            set;
        }

        public int ConsumedByNation
        {
            get;
            set;
        }

        public bool ProducedInCapitals
        {
            get;
            set;
        }

        public bool ProducedInTowns
        {
            get;
            set;
        }

        public bool ConsumedInCapitals
        {
            get;
            set;
        }

        public bool ConsumedInTowns
        {
            get;
            set;
        }
    }

    public class Result
    {
        public int Template
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public float Chance
        {
            get;
            set;
        }
    }

    public class Sellprice
    {
        public float x
        {
            get;
            set;
        }

        public float y
        {
            get;
            set;
        }
    }

    public class Sellprice_int
    {
        public int Min
        {
            get;
            set;
        }

        public int Max
        {
            get;
            set;
        }
    }

    public class Ship
    {
        public string __type
        {
            get;
            set;
        }

        public float RepairPriceCoefficient
        {
            get;
            set;
        }

        public int Class
        {
            get;
            set;
        }

        public string ShipTemplateName
        {
            get;
            set;
        }

        public Specs Specs
        {
            get;
            set;
        }

        public int VisualTemplateId
        {
            get;
            set;
        }

        public int[] HiddenModuleTemplates
        {
            get;
            set;
        }

        public object[] DefaultCannons
        {
            get;
            set;
        }

        public int[] BotCannons
        {
            get;
            set;
        }

        public Botcannonsvariant[] BotCannonsVariants
        {
            get;
            set;
        }

        public int MaxItems
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public bool PreventTeleport
        {
            get;
            set;
        }

        public int DropChanceReductionPerItem
        {
            get;
            set;
        }

        public int MaxStack
        {
            get;
            set;
        }

        public int ItemWeight
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public Sellprice SellPrice
        {
            get;
            set;
        }

        public Buyprice BuyPrice
        {
            get;
            set;
        }

        public int PriceReductionAmount
        {
            get;
            set;
        }

        public float ConsumedScale
        {
            get;
            set;
        }

        public int NonConsumedScale
        {
            get;
            set;
        }

        public int PriceTierQuantity
        {
            get;
            set;
        }

        public int MaxQuantity
        {
            get;
            set;
        }

        public string SortingGroup
        {
            get;
            set;
        }

        public bool SellableInShop
        {
            get;
            set;
        }

        public bool CanBeSoldToShop
        {
            get;
            set;
        }

        public bool ResetStockOnServerStart
        {
            get;
            set;
        }

        public float SellPriceCoefficient
        {
            get;
            set;
        }

        public string ItemType
        {
            get;
            set;
        }

        public string MongoID
        {
            get;
            set;
        }

        public int BaseDurability
        {
            get;
            set;
        }

        public int[] QualityPrices
        {
            get;
            set;
        }

        public bool Premium
        {
            get;
            set;
        }

        public string CaptureType
        {
            get;
            set;
        }

        public bool CanBeUsedInFleet
        {
            get;
            set;
        }

        public int FleetHirePriceCoefficient
        {
            get;
            set;
        }

        public int CanBeSoldOnlyIn
        {
            get;
            set;
        }

        public Repairkits RepairKits
        {
            get;
            set;
        }

        public Repairkitpricemodifier RepairKitPriceModifier
        {
            get;
            set;
        }

        public Repairkitcooldownmodifier RepairKitCooldownModifier
        {
            get;
            set;
        }

        public float RepairAmount
        {
            get;
            set;
        }

        public Healthinfo HealthInfo
        {
            get;
            set;
        }

        public int ShipMass
        {
            get;
            set;
        }

        public int BattleRating
        {
            get;
            set;
        }

        public int ShipType
        {
            get;
            set;
        }

        public int HiddenModulesCount
        {
            get;
            set;
        }

        public int PersistentModulesCount
        {
            get;
            set;
        }

        public int UpgradeModulesCount
        {
            get;
            set;
        }

        public int MinUpgradeModulesCount
        {
            get;
            set;
        }

        public Upgrademoduleslimit[] UpgradeModulesLimit
        {
            get;
            set;
        }

        public int OfficerSlots
        {
            get;
            set;
        }

        public int Decks
        {
            get;
            set;
        }

        public Deckclasslimit[] DeckClassLimit
        {
            get;
            set;
        }

        public int FrontDecks
        {
            get;
            set;
        }

        public Frontdeckclasslimit[] FrontDeckClassLimit
        {
            get;
            set;
        }

        public int BackDecks
        {
            get;
            set;
        }

        public Backdeckclasslimit[] BackDeckClassLimit
        {
            get;
            set;
        }

        public int MortarDecks
        {
            get;
            set;
        }

        public object[] MortarDeckClassLimit
        {
            get;
            set;
        }

        public int HoldSize
        {
            get;
            set;
        }

        public int MaxWeight
        {
            get;
            set;
        }

        public int MinCrewRequired
        {
            get;
            set;
        }

        public int ShipClassType
        {
            get;
            set;
        }

        public Skin[] Skins
        {
            get;
            set;
        }

        public int HostilityScore
        {
            get;
            set;
        }

        public int Limitation1_Value
        {
            get;
            set;
        }

        public int Limitation2_Value
        {
            get;
            set;
        }

        public int Limitation3_Value
        {
            get;
            set;
        }

        public bool ShowInContractsSelector
        {
            get;
            set;
        }

        public Deliveryorderoptions DeliveryOrderOptions
        {
            get;
            set;
        }

        public Portprices PortPrices
        {
            get;
            set;
        }
    }

    public class Skin
    {
        public string SkinName
        {
            get;
            set;
        }
    }

    public class Specs
    {
        public int MaxPassableHeight
        {
            get;
            set;
        }

        public float MaxSpeed
        {
            get;
            set;
        }

        public float MaxTurningSpeed
        {
            get;
            set;
        }

        public float Acceleration
        {
            get;
            set;
        }

        public float Deceleration
        {
            get;
            set;
        }

        public float[] SpeedToWind
        {
            get;
            set;
        }

        public float[] TurnToSpeed
        {
            get;
            set;
        }

        public int VisibilityDistanceScaleSelf
        {
            get;
            set;
        }

        public int VisibilityDistanceScaleOthers
        {
            get;
            set;
        }

        public int AttackDistanceScaleSelf
        {
            get;
            set;
        }

        public int AttackDistanceScaleOthers
        {
            get;
            set;
        }

        public int HailDistanceScaleSelf
        {
            get;
            set;
        }

        public int HailDistanceScaleOthers
        {
            get;
            set;
        }

        public int HailNationDisguiseSelf
        {
            get;
            set;
        }

        public int HailNationDisguiseOthers
        {
            get;
            set;
        }

        public int FullBattleRating
        {
            get;
            set;
        }

        public int BattleRating
        {
            get;
            set;
        }
    }

    public class Storage
    {
        public Storage_Resources[] Storage_Resources
        {
            get;
            set;
        }

        public Storage_Materials[] Storage_Materials
        {
            get;
            set;
        }

        public Storage_LabourHours[] Storage_LabourHours
        {
            get;
            set;
        }

        public Storage_Ship_Recipes[] Storage_Ship_Recipes
        {
            get;
            set;
        }
    }

    public class Storage_LabourHours
    {
        public string Name
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }
    }

    public class Storage_Materials
    {
        public string Name
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public double ItemWeight
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
    }

    public class Storage_Resources
    {
        public string Name
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }

        public int BasePrice
        {
            get;
            set;
        }

        public double ItemWeight
        {
            get;
            set;
        }

        public int AutoFillPrice
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public int ProducedByNation
        {
            get;
            set;
        }
    }

    public class Storage_Ship_Recipes
    {
        public string Name
        {
            get;
            set;
        }

        public bool Checked
        {
            get;
            set;
        }
    }

    public class Upgrademoduleslimit
    {
        public Limitation1 Limitation1
        {
            get;
            set;
        }

        public Limitation2 Limitation2
        {
            get;
            set;
        }

        public Limitation3 Limitation3
        {
            get;
            set;
        }
    }

    public class Woodtypedesc
    {
        public int WoodType
        {
            get;
            set;
        }

        public Requirement[] Requirements
        {
            get;
            set;
        }
    }

}
