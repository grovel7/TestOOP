using System;
using SwinAdv;
namespace SwinAdvTest
{
    public class LookCommandTest
    {
        Item gem1, gem2;
        Player player;
        Bag b1;
        //private Bag b2;
        LookCommand command;

        [SetUp]
        public void SetUp()
        {
            b1 = new Bag(new string[] { "bagb1" }, "backpack", "a small bag");
            gem1 = new Item(new string[] { "ruby" }, "a red gem", "a cool item");
            gem2 = new Item(new string[] { "emerald" }, "a green gem", "a rare item");
            player = new Player("Sarthak", "finder of lost grace");
            command = new LookCommand();
        }


        [Test]
        public void TestLookAtMe()
        {
            player.Inventory.Put(gem1);
            string output = command.Execute(player, new string[] { "look", "at", "me" });
            Assert.That(output, Is.EqualTo("Sarthak, you are carrying: a red gem (ruby)"));
        }

        [Test]
        public void TestLookAtGem()
        {
            player.Inventory.Put(gem1);
            string output = command.Execute(player, new string[] { "look", "at", "ruby" });
            Assert.That(output, Is.EqualTo("a cool item"));
        }

        [Test]
        public void TestLookAtUnk()
        {
            string output = command.Execute(player, new string[] { "look", "at", "ruby" });
            Assert.That(output, Is.EqualTo("I cannot find the ruby"));
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            player.Inventory.Put(gem1);
            string output = command.Execute(player, new string[] { "look", "at", "ruby", "in", "inventory" });
            Assert.That(output, Is.EqualTo("a cool item"));
        }



        [Test]
        public void TestLookAtGemInBag()
        {
            b1.Inventory.Put(gem1);
            player.Inventory.Put(b1);
            string output = command.Execute(player, new string[] { "look", "at", "ruby", "in", "bagb1" });
            Assert.That(output, Is.EqualTo("a cool item"));
        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            b1.Inventory.Put(gem1);
            string output = command.Execute(player, new string[] { "look", "at", "ruby", "in", "bagb1" });
            Assert.That(output, Is.EqualTo("I cannot find the bagb1"));
        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            player.Inventory.Put(b1);
            string output = command.Execute(player, new string[] { "look", "at", "ruby", "in", "bagb1" });
            Assert.That(output, Is.EqualTo("I cannot find the ruby"));
        }

        
        [Test]
        public void TestInvalidLook()
        {
            player.Inventory.Put(b1);
            string output = command.Execute(player, new string[] { "hel", "search" });
            Assert.That(output, Is.EqualTo("I don't know how to look like that"));
            output = command.Execute(player, new string[] { "search", "this", "error" });
            Assert.That(output, Is.EqualTo("Error in look output"));
            output = command.Execute(player, new string[] { "look", "search", "gg" });
            Assert.That(output, Is.EqualTo("What do you want to look at?"));
        }
    }
}