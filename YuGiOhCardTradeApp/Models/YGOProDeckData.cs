using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YuGiOhCardTradeApp.Models;

namespace YuGiOhCardTradeApp2.Models
{
  
    public class YGOProDeckData
    {
        public List<Datum> data { get; set; }
        public static List<Card> MapCardsFromData(YGOProDeckData data)
        {
            var cards = new List<Card>();
            if (data != null && data.data != null)
            {
                foreach (var datum in data.data)
                {
                    var card = new Card();
                    card.Archetype = datum.archetype;
                    card.Id = datum.id;
                    card.Name = datum.name;
                    card.Description = datum.desc;
                    card.Attack = datum.atk;
                    card.Defence = datum.def;
                    card.Level = datum.level;
                    card.Race = datum.race;
                    card.Attribute = datum.attribute;
                    card.Linkval = datum.linkval ?? 0;
                    //card.LinkMarkers = datum.linkmarkers;
                    if (datum.card_sets != null && datum.card_sets.Count > 0)
                    {
                        var cardsets = new List<CardSet>();
                        foreach (var cardset in datum.card_sets)
                        {
                            var mappedcardset = new CardSet();
                            mappedcardset.Card = card;
                            mappedcardset.CardId = card.Id;
                            mappedcardset.SetCode = cardset.set_code;
                            mappedcardset.SetPrice = cardset.set_price;
                            mappedcardset.SetRarity = cardset.set_rarity;
                            mappedcardset.SetRarityCode = cardset.set_rarity_code;
                            mappedcardset.SetName = cardset.set_name;
                            cardsets.Add(mappedcardset);

                        }
                    }
                    else
                    {
                        card.Card_sets = new List<CardSet>();
                    }
                    if (datum.card_images != null && datum.card_images.Count > 0)
                    {
                        var cardimages = new List<CardImage>();
                        foreach (var cardimage in datum.card_images)
                        {
                            var mappedcardimage = new CardImage();
                            mappedcardimage.Card = card;
                            mappedcardimage.CardId = card.Id;
                            mappedcardimage.ImageUrl = cardimage.image_url;
                            mappedcardimage.ImageUrlSmall = cardimage.image_url_small;
                            cardimages.Add(mappedcardimage);
                        }
                    }
                    else
                    {
                        card.Card_images = new List<CardImage>();
                    }
                    if (datum.card_prices != null && datum.card_prices.Count > 0)
                    {
                        var cardprices = new List<CardPrice>();

                        foreach (var cardprice in datum.card_prices)
                        {
                            var mappedcardprice = new CardPrice();
                            mappedcardprice.Card = card;
                            mappedcardprice.CardId = card.Id;
                            mappedcardprice.AmazonPrice = Convert.ToDouble(cardprice.amazon_price);
                            mappedcardprice.CardmarketPrice = Convert.ToDouble(cardprice.cardmarket_price);
                            mappedcardprice.CoolStuffIncPrice = Convert.ToDouble(cardprice.coolstuffinc_price);
                            mappedcardprice.EbayPrice = Convert.ToDouble(cardprice.ebay_price);
                            mappedcardprice.TcgPlayerPrice = Convert.ToDouble(cardprice.tcgplayer_price); 
                            cardprices.Add(mappedcardprice);
                        }

                    }

                    else
                    {
                        card.Card_prices = new List<CardPrice>();
                    }
                        cards.Add(card);
                    }
                }
                return cards;
            }
        }
    }

    
    public class YGOCardSet    {
        public string set_name { get; set; } 
        public string set_code { get; set; } 
        public string set_rarity { get; set; } 
        public string set_rarity_code { get; set; } 
        public string set_price { get; set; } 
    }

    public class YGOCardImage    {
        public int id { get; set; } 
        public string image_url { get; set; } 
        public string image_url_small { get; set; } 
    }

    public class YGOCardPrice    {
        public string cardmarket_price { get; set; } 
        public string tcgplayer_price { get; set; } 
        public string ebay_price { get; set; } 
        public string amazon_price { get; set; } 
        public string coolstuffinc_price { get; set; } 
    }

    public class Datum    {
        public int id { get; set; } 
        public string name { get; set; } 
        public string type { get; set; } 
        public string desc { get; set; } 
        public int atk { get; set; } 
        public int def { get; set; } 
        public int level { get; set; } 
        public string race { get; set; } 
        public string attribute { get; set; } 
        public string archetype { get; set; } 
        public int? linkval { get; set; } 
        public List<string> linkmarkers { get; set; }
        public List<YGOCardSet> card_sets { get; set; } 
        public List<YGOCardImage> card_images { get; set; } 
        public List<YGOCardPrice> card_prices { get; set; } 
}



