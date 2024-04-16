using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SwinAdv;

namespace SwinAdvTest
{
    public class TestInventory
    {
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
        //Inventory i = new Inventory();
        

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void TestFindItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Assert.True(i.HastItem(shovel.FirstId)); 
        }

        [Test]


        public void TestNoItemfind()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Assert.IsFalse(i.HastItem(sword.FirstId));
        }




        [Test]
        public void TestFetchItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            Item fetchItem = i.Fetch(shovel.FirstId);
            Assert.AreEqual(fetchItem, shovel);//returns the item it has
            Assert.IsTrue(i.HastItem(shovel.FirstId));
        }

        [Test]
        public void TestTakeItem()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            i.Take(shovel.FirstId);

            Assert.IsFalse(i.HastItem(shovel.FirstId));

        }

        [Test]
        public void TestItemList()
        {
            Inventory i = new Inventory();
            i.Put(shovel);
            i.Put(sword);

            Assert.IsTrue(i.HastItem(shovel.FirstId) && i.HastItem(sword.FirstId));

            //for chceking the short description

            string result = "a shovel (shovel)" + "a sword (sword)";
            Assert.AreEqual(i.ItemList, result);

        }
    }
}