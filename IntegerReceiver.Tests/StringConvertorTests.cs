using System;
using NUnit.Framework;

namespace IntegerReceiver.Tests
{
    public class StringConvertorTests
    {
        [TestCase("0110111101100001100001010111111", 2, ExpectedResult = 934331071)]
        [TestCase("01101111011001100001010111111", 2, ExpectedResult = 233620159)]
        [TestCase("11101101111011001100001010111111", 2, ExpectedResult = 3991716543)]
        [TestCase("11111111111111111111111111111111", 2, ExpectedResult = uint.MaxValue)]
        [TestCase("1AEF101", 16, ExpectedResult = 28242177)]
        [TestCase("1ACB67", 16, ExpectedResult = 1756007)]
        [TestCase("764241", 8, ExpectedResult = 256161)]
        [TestCase("10", 5, ExpectedResult = 5)]
        public uint StringConvertor_WithNumbers(string initString, int notation) =>
            initString.ConvertToInt(notation);

        [Test]
        public void StringConverter_ArgumentExceptionCall_WrongNotation() 
            => Assert.Throws<ArgumentException>(() => "1AEF101".ConvertToInt(2));
        [Test]
        public void StringConverter_ArgumentExceptionCall_InvalidNotation() 
            => Assert.Throws<ArgumentOutOfRangeException>(() => "1010101".ConvertToInt(20));
        [Test]
        public void StringConverter_ArgumentExceptionCall_InvalidCharacter()
           => Assert.Throws<ArgumentException>(() => "SSSSSS".ConvertToInt(2));
    }
}
