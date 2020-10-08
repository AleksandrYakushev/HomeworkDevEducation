using NUnit.Framework;

namespace AVLTree.tests
{
    public class TreeTestsInt
    {
        Tree<int> treeInt;
        [SetUp]
        public void Setup()
        {
            treeInt = new Tree<int>();

            treeInt.Add(10);
            treeInt.Add(40);
            treeInt.Add(35);
            treeInt.Add(30);
            treeInt.Add(18);
            treeInt.Add(40);
            
        }

        [TestCase(22, true)]
        [TestCase(2, true)]
        [TestCase(0, true)]
        public void AddTest(int value, bool expected)
        {
            treeInt.Add(value);
            bool actual = treeInt.Contains(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(40, true)]
        [TestCase(18, false)]
        [TestCase(12, false)]
        public void RemoveTest(int value, bool expected)
        {
            treeInt.Remove(value);
            bool actual = treeInt.Contains(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(47, false)]
        
        public void ClearTest(int value, bool expected)
        {
            treeInt.Add(value);
            treeInt.Clear();
            bool actual = treeInt.Contains(value);

            Assert.AreEqual(expected, actual);
        }
    }
}