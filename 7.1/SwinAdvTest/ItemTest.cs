using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SwinAdv;

namespace SwinAdvTest
{
    public class TestItem
    {
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestItemIdentifiable()

        {
            Assert.IsTrue(shovel.AreYou("shovel"));
            Assert.IsFalse(shovel.AreYou("sword"));
        }

        [Test]
        public void ShortDescriptionTest()
        {
            Assert.AreEqual(shovel.ShortDescription, "a shovel (shovel)");
        }

        [Test]
        public void FullDescriptionTest() //returns the items description
        {
            Assert.AreEqual(shovel.FullDescription , "This is a shovel");
        }

        
        
    }
}