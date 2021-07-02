using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace P01BinaryGap.Tests
{
    [TestClass]
    public class BinaryGapTests
    {
        [TestMethod]
        public void ReturnsProperBinaryGapNumberWhenIntegerNumberInput()
        {
            var binaryGapHelper = new BinaryGapHelper();
            
            var number1 = 1054;
            var number2 = 100;
            var number3 = 64;
            var number4 = 14512;

            Assert.AreEqual(5, binaryGapHelper.BinaryGap(number1));
            Assert.AreEqual(2, binaryGapHelper.BinaryGap(number2));
            Assert.AreEqual(0, binaryGapHelper.BinaryGap(number3));
            Assert.AreEqual(3, binaryGapHelper.BinaryGap(number4));
        }
    }
}
