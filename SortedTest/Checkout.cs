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

        private List<string> scannedWithOffer = new List<string>();

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
                    // first we need to track what item was scanned and determine how many of that item we have scanned so far
                    // create a list to store scanned items with an offer, store the SKU's
                    // then count those SKU's to see if we have reached the amount required for an offer
                    scannedWithOffer.Add(item.SKU);
                    // so far this list is storing any SKU that has been scanned an has an offer
                    // what we really want to is to count SKU's that are the same
                    // need a different function for that
                    int howMany = countSKU(scannedWithOffer, item.SKU);
                    // now we now how many of that SKU are in the list
                    // if how many is evenly divisible by the offer amount then we have enough for the offer to take effect
                    if (howMany % item.offerAmnt == 0)
                    {
                        Console.WriteLine("ENOUGH FOR OFFER!");
                        // since this completes an offer we must subtract any previous instances of item.unitprice that has been added
                        total -= (item.offerAmnt - 1) * item.UnitPrice;
                        //then we can add the offer price instead
                        total += item.offerPice;
                    }
                }
                else
                {
                    total += item.UnitPrice;
                }
                Console.WriteLine("END TOTAL:  " + total);
            }
        }

        // this function will count how many of a specific SKU occur in a list of SKU's
        private int countSKU(List<string> skus, string sku)
        {
            int count = 0;
            foreach(string s in skus)
            {
                if(s != null && s == sku)
                {
                    count++;
                }
            }
            return count;
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
