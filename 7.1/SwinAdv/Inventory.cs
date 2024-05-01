using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SwinAdv;

namespace SwinAdv
{
    public class Inventory
    {
        List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HastItem(string id)
        {
            foreach(Item i in _items)
            {
               if( i.AreYou(id))
                {
                    return true;
                }
            }
            return false;

        }
        public void Put(Item itm)
        {
            _items.Add(itm);

        }
        public Item Take(string id)
        {
            Item takeItem = this.Fetch(id); //to locate the item and store it in takeItem
            _items.Remove(takeItem);

            return takeItem;


        }
        public Item Fetch(string id)
        {
            //locate an item by id and return it
            foreach (Item i in _items)
            {
                //check by AreYou
                if(i.AreYou(id))
                {
                    return i;
                }
            }
            return null;
        }

        public string ItemList
        {
            get
            {
                string listItem = "";
                foreach (Item i in _items)
                {
                    
                    listItem = listItem + i.ShortDescription + ",\n";
                }
                return listItem;
            }
        }

    }
}