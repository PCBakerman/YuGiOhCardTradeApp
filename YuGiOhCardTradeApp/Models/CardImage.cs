using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YuGiOhCardTradeApp.Models;

namespace YuGiOhCardTradeApp2.Models
{
    public class CardImage
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlSmall { get; set; }
    }
}
