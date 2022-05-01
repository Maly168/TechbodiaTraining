using NUnit.Framework;

namespace TechbodiaTraining.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(21, "XXI")]
        [TestCase(1, "I")]
        [TestCase(1994, "MCMXCIV")]
        [TestCase(2041, "MMXLI")]
        [TestCase(1666, "MDCLXVI")]
        public void RomanNumberI_Should_equal_to_1(int expected, string roman)
        {
            Assert.AreEqual(expected, int.Parse(RomanDecoderService.DecodeRomanToInteger(roman)));
        }

        [TestCase(21, "XXI")]
        public void RomanNumberXXI_should_equal_to_21(int expected, string roman)
        {
            Assert.AreEqual(expected, int.Parse(RomanDecoderService.DecodeRomanToInteger(roman)));
        }

        [TestCase("Invalid roman number", "NO")]
        public void No_should_Invalid_roman_number(string expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecoderService.DecodeRomanToInteger(roman));
        }
    }
}