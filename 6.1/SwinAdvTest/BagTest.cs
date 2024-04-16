using System;
using SwinAdv;
namespace SwinAdvTest
{
	public class BagTest
	{
		Bag b;
		Bag b1;
		Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item silver = new Item(new string[] { "silver" }, "a silver", "This is a silver");
        Item gold = new Item(new string[] { "gold" }, "a gold", "This is a gold");

        [SetUp]
		public void Setup()
		{
			b = new Bag(new string[] { "bag"} , "a bag" ,"This is a bag");
            b1 = new Bag(new string[] { "bag1" }, "a bag1", "This is a bag1");

			//adding item in the bag

			b.Inventory.Put(sword);
            b.Inventory.Put(shovel);
            b.Inventory.Put(silver);

            //adding items in bag2


            b1.Inventory.Put(gold);

        }
		[Test]
		public void TestBagLocatesItems()
		{
			Assert.IsTrue(b.Inventory.HastItem("sword"));
            Assert.IsTrue(b.Inventory.HastItem("shovel"));

			Assert.IsTrue(b.Locate(sword.FirstId) == sword);
			Assert.IsTrue(b.Locate(shovel.FirstId) == shovel);


        }

		[Test ]
		public void TestBagLocatesItself()
		{
			Assert.IsTrue(b.Locate(b.FirstId) == b);
            Assert.IsTrue(b.Locate("bag") == b);

        }

		[Test ]
		public void TestBagLocatesNothing()
		{
			Assert.IsTrue(b.Locate(gold.FirstId) == null);
		}

		[Test]
		public void TestBagFullDescription()
		{
            string testBagDescription = $"In the {b.Name} you can see:\n{b.Inventory.ItemList}";
            Assert.That(testBagDescription, Is.EqualTo(b.FullDescription));
		}

		[Test ]
		public void TestBaginBag()
		{
			b.Inventory.Put(b1);

			// Tests that a bag can locate a bag held within it
			Assert.That(b.Locate("bag1"), Is.EqualTo(b1));

			//b can locate other items in b

			Assert.That(b.Locate("silver"), Is.EqualTo(silver));
			Assert.That(b.Locate("sword"), Is.EqualTo(sword));
            Assert.That(b.Locate("shovel"), Is.EqualTo(shovel));


            // test that b cannot locate items within b1
            Assert.That(b.Locate("gold"), Is.EqualTo(null));


        }
    }
}

