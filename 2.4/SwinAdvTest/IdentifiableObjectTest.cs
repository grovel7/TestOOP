using System;
using _2._4;
namespace SwinAdvTest
{
	public class IdentifiableObjectTest
	{
        private string _testString;
        private string[] _testArray;
        private IdentifiableObject _testObject;

        // for empty fields
        private string _testStringEmp;
        private string[] _testArrayEmp;
        private IdentifiableObject _testObjectEmp;


        [SetUp]
        public void Setup()
        {
            _testString = "Fred";
            _testArray = new string[] { "fred", "bob" };
            _testObject = new IdentifiableObject(_testArray);
            _testObject.AddIdentifier(_testString);

            //for empty tests

            //instacnes
            _testStringEmp = "";
            _testArrayEmp = new string[] { };
            _testObjectEmp = new IdentifiableObject(_testArrayEmp);
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_testObject.AreYou(_testString));
        }
        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(_testObject.AreYou("Sar"));
        }
        [Test]
        public void TestCaseSensetive()
        {
            Assert.IsTrue(_testObject.AreYou("fRed"));
        }
        [Test]
        public void TestFirstId()
        {
            //check if it returns the first id in the list of identifiers
            Assert.That(_testObject.FirstId, Is.EqualTo("fRed").IgnoreCase); //case insensitive
            Assert.That(_testObject.FirstId, Is.Not.EqualTo("Sar").IgnoreCase);
        }
        [Test]
        public void TestFirstIdWithNoId()
        {
            Assert.That(_testObjectEmp.FirstId, Is.EqualTo(""));
        }
        [Test]
        public void TestAddId() //Check that you can add identifiers to the object.
        {
            _testObject.AddIdentifier("wilma");
            Assert.IsTrue(_testObject.AreYou("wilma"));
            Assert.IsTrue(_testObject.AreYou("fred"));
            Assert.IsTrue(_testObject.AreYou("bob"));
        }
    }
}

