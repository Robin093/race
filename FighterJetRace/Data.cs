using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterJetRace
{
    abstract class Data
    {
        public static FighterJet[] jet = new FighterJet[4];
        public static PlacerBet[] bettor = new PlacerBet[3];
        public static Random rand = new Random();
        public static int currentGambler { get; set; }
    }
}
