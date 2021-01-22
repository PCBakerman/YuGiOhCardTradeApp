using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YuGiOhCardTradeApp.Models;

namespace YuGiOhCardTradeApp2.Models
{
    public class CardPrice
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public double CardmarketPrice { get; set; }
        public double TcgPlayerPrice { get; set; }
        public double EbayPrice { get; set; }
        public double AmazonPrice { get; set; }
        public double CoolStuffIncPrice { get; set; }
    }
}
