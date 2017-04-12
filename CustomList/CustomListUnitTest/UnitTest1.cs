using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
//Add tests

        //int add test
        [TestMethod]
        public void IntAddTest()
        {
            //Arrange
            CustomList<int> intList = new CustomListUnitTest<int>();
            int item = 5;

            //Act
            intList.Add(item);

            //Assert
            Assert.AreEqual(item, intList[0]);
        }

        //string add test
        [TestMethod]
        public void StringAddTest()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();
            string item = "This is my string";

            //Act
            stringList.Add(item);

            //Assert
            Assert.AreEqual(item, stringList[0]);
        }

        //object add test
        [TestMethod]
        public void ObjectAddTest()
        {
            CustomList<Item> itemList = new CustomList<Item>();
            Item something = new Item("stuff", 34, "more");

            itemList.Add(something);

            Assert.AreEqual(something, objList[0]);
        }

//Remove Tests
        [TestMethod]
        public void IntRemoveTest()
        {
            CustomList<int> intList = new CustomList<int>();
            int removeItem = 1;
            intList.Add(item);
            intList.Add(2);
            intList.Add(3);

            int result = list.Remove();

            Assert.AreEqual(removeItem, result);
        }

        [TestMethod]
        public void StringRemoveTest()
        {
            CustomList<string> stringList = new CustomList<string>();
            string removeItem = "Buh Bye";
            stringList.Add(item);
            stringList.Add("Staying");
            stringList.Add("Keep");

            string result = list.Remove();

            Assert.AreEqual(removeItem, result);
        }

        [TestMethod]
        public void Remove_CustomObject()
        {
            CustomList<Item> itemList = new CustomList<Item>();
            // Arrange
            Item item = new Item();
            list.Add(item);
            bool result;

            // Act
            result = list.Remove(item);

            // Assert
            Assert.AreEqual(true, result);
        }

 //ToString Tests
        public void IntToStringTest()
        {
            CustomList<int> intList = new CustomList<int>();
            int item = 1;
            intList.Add(item);

            string result = intList.ToString();

            Assert.AreEqual(item, result);
        }

        public void stringToStringTest()
        {
            CustomList<string> stringList = new CustomList<string>();
            string item = "Add Item";
            stringList.Add(item);

            string result = stringList.ToString();

            Assert.AreEqual(item, result);
        }

        public void ToStringObjects()
        {
            Item item1 = new Item();
            item item2 = new Item();
            item1 item3 = new Item();
            CustomList<Item> itemList = new CustomList<Item>() { item1, item2, item3 };
            // Arrange
            string expected = $"{item1}, {item2}, {item3}";
            string result;

            // Act
            result = itemList.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }

// Plus Tests
        public void IntPlusTest()
        {
            // Arrange
            CustomList<int> first = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> second = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> result;

            // Act
            result = first + second;

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void StringPlusTest()
        {
            // Arrange
            CustomList<string> first = new CustomList<string>() { "Lets", "run", "these" };
            CustomList<string> second = new CustomList<string>() { "two", "strings", "together" };
            CustomList<string> expected = new CustomList<string>() { "Lets", "run", "these", "two", "strings", "together" };
            CustomList<string> result;

            // Act
            result = first + second;

            // Assert
            for (string i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void ObjectPlusTest()
        {
            Item item1 = new Item();
            Item item2 = new Item();
            Item item3 = new Item();
            // Arrange
            CustomList<Item> first = new CustomList<Item>() { item1, item2 };
            CustomList<Item> second = new CustomList<Item>() { item3 };
            CustomList<Item> expected = new CustomList<Item>() { item1, item2, item3 };
            CustomList<Item> result;

            // Act
            result = first + second;

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        public void IntMinusTest()
        {
            // Arrange
            CustomList<int> first = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> second = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> result;

            // Act
            result = first - second;

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void StringMinusTest()
        {
            // Arrange
            CustomList<string> first = new CustomList<string>() { "Lets", "drop", "some", "strings", "from", "list" };
            CustomList<string> second = new CustomList<string>() { "Lets", "some", "list" };
            CustomList<string> expected = new CustomList<string>() { "drop", "strings", "list" };
            CustomList<string> result;

            // Act
            result = first - second;

            // Assert
            for (string i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void ObjectMinusTest()
        {
            Item item1 = new Item();
            Item item2 = new Item();
            Item item3 = new Item();
            // Arrange
            CustomList<Item> first = new CustomList<Item>() { item1, item2, item3 };
            CustomList<Item> second = new CustomList<Item>() { item2 };
            CustomList<Item> expected = new CustomList<Item>() { item1, item3 };
            CustomList<Item> result;

            // Act
            result = first - second;

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

//Count Tests
        [TestMethod]
        public void IntCountTest()
        {
            int size = 100;
            CustomList<int> intList = new CustomList<int>();
            for (int i = 0; i < size; i++)
            {
                intList.Add(i);
            }

            int result = intList.Count();

            Assert.AreEqual(size, result);
        }

        [TestMethod]
        public void StringCountTest()
        {
            string[] newString = new string[] { "Counting", "Strings", "is", "fun" };
            CustomList<string> stringList = new CustomList<string>();
            for (int i = 0; i < newString.Length; i++)
            {
                stringList.Add(names[i]);
            }

            int result = stringList.Count();

            Assert.AreEqual(newString.Length, result);
        }

//Zip Tests
        [TestMethod]
        public void ZipIntsTest()
        {
            // Arrange
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> result;

            // Act
            result = odd.Zip(even);

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void ZipstringsTest()
        {
            // Arrange
            CustomList<string> odd = new CustomList<string>() { "Green Bay", "Pittsburgh", "Dallas" };
            CustomList<string> even = new CustomList<string>() { "Packers", "Steelers", "Cowboys" };
            CustomList<string> expected = new CustomList<string>() { "Green Bay", "Packers", "Pittsburgh", "Steelers", "Dallas", "Cowboys" };
            CustomList<string> result;

            // Act
            result = odd.Zip(even);

            // Assert
            for (string i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }

        [TestMethod]
        public void Zip_Items()
        {
            // Arrange
            Item item1 = new Item();
            Item item2 = new Item();
            Item item3 = new Item();

            CustomList<Item> first = new CustomList<Item>() { item1, item3 };
            CustomList<Item> second = new CustomList<Item>() { item2 };
            CustomList<Item> expected = new CustomList<Item>() { item1, item2 };
            CustomList<Item> result;

            // Act
            result = first.Zip(second);

            // Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }
        }


    }
}
