using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void ReplicateArray_EmptyArray_ReturnsEmptyArray()
        {
            int[] original = Array.Empty<int>();
            int[] result = ArrayReplicator.ReplicateArray(original);
            CollectionAssert.AreEqual(original, result);
            Assert.AreNotSame(original, result);
        }

        [TestMethod]
        public void ReplicateArray_ArrayWithSingleElement()
        {
            int[] original = new int[] { 42 };
            int[] result = ArrayReplicator.ReplicateArray(original);
            CollectionAssert.AreEqual(original, result);
            Assert.AreNotSame(original, result);
        }

        [TestMethod]
        public void ReplicateArray_ArrayWithMultipleElements()
        {
            int[] original = new int[] { 1, 2, 3, 4, 5 };
            int[] result = ArrayReplicator.ReplicateArray(original);
            CollectionAssert.AreEqual(original, result);
            Assert.AreNotSame(original, result);
        }
    }
}
