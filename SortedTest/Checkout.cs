using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedTest
{
    class Checkout
    { 
        // Used to scan an item
        public void Scan(Item item)
        {

        }

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
