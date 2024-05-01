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
        Location _location;

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
                return $"{Name}, you are carrying: " + _inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }


        //players have a location
        public Location location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;

            }
        }

    }
}