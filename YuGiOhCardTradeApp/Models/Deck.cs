using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YuGiOhCardTradeApp2.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public int UserInventoryId { get; set; }
        public UserInventory UserInventory { get; set; }
        public string DeckName { get; set; }
        public string DeckImage { get; set; }
    }
}
