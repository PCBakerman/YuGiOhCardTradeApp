using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YuGiOhCardTradeApp2.Models;

namespace YuGiOhCardTradeApp.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Level { get; set; }
        public string Race { get; set; }
        public string Attribute { get; set; }
        public string Archetype { get; set; }
        public int Linkval { get; set; }
        public string LinkMarkers { get; set; }


        public List<CardSet> Card_sets { get; set; }
        public List<CardImage> Card_images { get; set; }
        public List<CardPrice> Card_prices { get; set; }


    }
}
