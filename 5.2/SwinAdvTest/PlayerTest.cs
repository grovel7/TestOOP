using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SwinAdv;

namespace SwinAdvTest
{
    public class TestPlayer
    {
        Player player = new Player("sarthak", "swinburne");
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "this is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "this is a sword");
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        //the player responds correctly to are you requests based on its default identifiers
        public void TestPlayerIdentifiable()
        {
            Assert.IsTrue(player.AreYou("me") && (player.AreYou("inventory")));
        }

        [Test]

        //can locate items in inventory and returns the item player has and also remaining items
        public void TestPlayerLocatesItem()
        {
            //add the item in the inventory
            player.Inventory.Put(shovel);
            var ItemsLocated = player.Locate("shovel");

            Assert.AreEqual(ItemsLocated, shovel);

        }

        [Test]
        //player returns itself if asked to locate "me" and "inventory"
        public void TestPlayerLocatesItself()
        {
            var LocatedMe = player.Locate("me");
            var LocatedInv = player.Locate("inventory");
            Assert.AreEqual(LocatedMe, player);
            Assert.AreEqual(LocatedInv, player);

        }

        [Test]
        //returns null if asked to locate it does not have

        public void TestPlayerLocatesNothing()

        {
            var NoItemLocated = player.Locate("qwe");
            Assert.AreEqual(null, NoItemLocated);
        }

        [Test]

        //the players full description
        public void TestPlayerFullDescription()
        {
            player.Inventory.Put(shovel);
            var resultDescription = player.FullDescription;
            string Result = "sarthak, you are carrying: a shovel (shovel)" ;      //return $"{Name}, you are carrying: " + _inventory.ItemList;
            Assert.AreEqual(Result, resultDescription);
        }
    }
}