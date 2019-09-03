using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedTest
{
    class Checkout
    {

        public decimal total = 0; // used to store the total price

        // Used to scan an item
        // expects an instance of an item
        public void Scan(Item item)
        {
            if(item != null)
            {
                // if the item is on offer, check to see if we have scanned enough of them
                // if so add the offer price and subtract out any previous UnitPrices for that item we have added
                // if not on offer then just add the usual UnitPrice

                if (item.hasOffer)
                {

                }
                else
                {
                    total += item.UnitPrice;
                }
            }
        }

        // Do we need this?
        // calculates and returns total price
        public decimal Total()
        {
            return 0;
        }
    }

    public class Item
    {
        // Item properties
        public string SKU; // item ID
        public decimal UnitPrice = 0; // individual item price (no offers)

        // properties if the item is on offer
        public bool hasOffer = false;
        public int offerAmnt = 0; // amount of this item required to trigger offer
        public decimal offerPice = 0; // cost of items on offer

        //Item constructor, requires and SKU and a price
        public Item(string inSKU, decimal inPrice)
        {
            SKU = inSKU;
            UnitPrice = inPrice;
        }

        // public function that adds an offer to this instance of Item
        // expects an int (amnt), determines how many of this item are required to trigger offer
        // expects a deciaml (price), determines the price of the offer
        public void addOffer(int amnt, decimal price)
        {
            this.hasOffer = true;
            this.offerAmnt = amnt;
            this.offerPice = price;
        }

    }
}
