using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YuGiOhCardTradeApp.Models;

namespace YuGiOhCardTradeApp2.Models
{
    public class CardSet
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public string SetName { get; set; }
        public string SetCode { get; set; }
        public string SetRarity { get; set; }
        public string SetRarityCode { get; set; }
        public string SetPrice { get; set; }
        
    }
}
