namespace SLL_LAB01
{
    [TestFixture]
    public class LinkedListTests
    {
        private LinkedList _linkedList;

        [SetUp]
        public void SetUp()
        {
            _linkedList = new LinkedList();
        }

        [Test]
        public void AddFirst_AddsNodeToBeginningOfList()
        {
            _linkedList.AddFirst("Jane Doe");
            Assert.AreEqual("Jane Doe", _linkedList.GetValue(0));
            Assert.AreEqual(1, _linkedList.Count);

            _linkedList.AddFirst("John Smith");
            Assert.AreEqual("John Smith", _linkedList.GetValue(0));
            Assert.AreEqual("Jane Doe", _linkedList.GetValue(1));
            Assert.AreEqual(2, _linkedList.Count);
        }

        [Test]
        public void AddLast_AddsNodeToEndOfList()
        {
            _linkedList.AddLast("Jane Doe");
            Assert.AreEqual("Jane Doe", _linkedList.GetValue(0));
            Assert.AreEqual(1, _linkedList.Count);

            _linkedList.AddLast("John Smith");
            Assert.AreEqual("Jane Doe", _linkedList.GetValue(0));
            Assert.AreEqual("John Smith", _linkedList.GetValue(1));
            Assert.AreEqual(2, _linkedList.Count);
        }

        [Test]
        public void RemoveFirst_RemovesFirstNodeInList()
        {
            _linkedList.AddFirst("Jane Doe");
            _linkedList.AddFirst("John Smith");

            _linkedList.RemoveFirst();
            Assert.AreEqual("Jane Doe", _linkedList.GetValue(0));
            Assert.AreEqual(1, _linkedList.Count);

            _linkedList.RemoveFirst();
            Assert.IsNull(_linkedList.GetValue(0));
            Assert.AreEqual(0, _linkedList.Count);
        }

        [Test]
        public void RemoveLast_RemovesLastNodeInList()
        {
            _linkedList.AddFirst("Jane Doe");
            _linkedList.AddFirst("John Smith");

            _linkedList.RemoveLast();
            Assert.AreEqual("John Smith", _linkedList.GetValue(0));
            Assert.IsNull(_linkedList.GetValue(1));
            Assert.AreEqual(1, _linkedList.Count);

            _linkedList.RemoveLast();
            Assert.IsNull(_linkedList.GetValue(0));
            Assert.AreEqual(0, _linkedList.Count);
        }

        [Test]
        public void GetValue_RetrievesValueOfNodeAtGivenIndex()
        {
            string[] names = { "Joe Blow", "Joe Schmoe", "John Smith", "Jane Doe", "Bob Bobberson", "Sam Sammerson", "Dave Daverson" };

            foreach (string name in names)
                _linkedList.AddLast(name);

            for (int i = 0; i < names.Length; i++)
                Assert.AreEqual(names[i], _linkedList.GetValue(i));

            Assert.IsNull(_linkedList.GetValue(-1));
            Assert.IsNull(_linkedList.GetValue(names.Length));
        }
    }
}
