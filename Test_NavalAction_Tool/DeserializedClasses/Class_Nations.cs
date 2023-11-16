using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_NavalAction_Tool
{

    public class Nations
    {
        public int FreeTownNation { get; set; }
        public Nation[] Nation { get; set; }
        public int NeutralNation { get; set; }
        public int PiratesNation { get; set; }
        public int[] RelationshipTable { get; set; }
    }

    public class Nation
    {
        public string Name { get; set; }
        public bool CanBeUsedAsBotFiller { get; set; }
        public bool CanBeUsedByPlayers { get; set; }
        public bool CanBeVotedFor { get; set; }
        public int MaxBots { get; set; }
        public int Id { get; set; }
    }

}
