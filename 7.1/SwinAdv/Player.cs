using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SwinAdv;
using System.Xml.Linq;

namespace SwinAdv
{
    public class Player : GameObject, IHaveInventory //implement
    {
        Inventory _inventory;

        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if(AreYou(id))
            {
                return this; //reference variable of gameobject
            }
            return _inventory.Fetch(id);
        }

        public override string FullDescription
        {
            get
            {
                //string items = string.Join("\n", _inventory.ItemList);
                return $"{Name}, you are carrying: \n" + _inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
        

    }
}