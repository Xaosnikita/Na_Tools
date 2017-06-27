using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_NavalAction_Tool
{
    public class Port
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Position Position { get; set; }
        public Entranceposition EntrancePosition { get; set; }
        public bool SecondEntrancePositionValid { get; set; }
        public Secondentranceposition SecondEntrancePosition { get; set; }
        public Portbattlezoneposition[] PortBattleZonePositions { get; set; }
        public float Rotation { get; set; }
        public int Nation { get; set; }
        public string CountyCapitalName { get; set; }
        public string CountyCapitalIndex { get; set; }
        public string[] CountyPorts { get; set; }
        public int ConquestMarksPension { get; set; }
        public bool NationStartingPort { get; set; }
        public bool NationRookieStartingPort { get; set; }
        public bool Capital { get; set; }
        public bool Regional { get; set; }
        public bool CanBeUsedByBots { get; set; }
        public bool NeedsGuards { get; set; }
        public int Depth { get; set; }
        public int Size { get; set; }
        public int Contested { get; set; }
        public Sourceposition sourcePosition { get; set; }
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Capturer { get; set; }
        public int ConquestFlagTimeSlot { get; set; }
        public string PortBattleType { get; set; }
        public long LastPortBattle { get; set; }
        public Portelement[] PortElements { get; set; }
        public Portelementsslotgroup[] PortElementsSlotGroups { get; set; }
    }

    public class Position
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Entranceposition
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Secondentranceposition
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Sourceposition
    {
        public float x { get; set; }
        public float y { get; set; }
    }

    public class Portbattlezoneposition
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Portelement
    {
        public Position1 Position { get; set; }
        public Direction Direction { get; set; }
        public string TemplateName { get; set; }
    }

    public class Position1
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Direction
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Portelementsslotgroup
    {
        public string TemplateName { get; set; }
        public Portelementsslot[] PortElementsSlots { get; set; }
    }

    public class Portelementsslot
    {
        public Position2 Position { get; set; }
        public Direction1 Direction { get; set; }
    }

    public class Position2
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Direction1
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

}
