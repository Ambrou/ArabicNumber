using ArabicToRomanConverter;
using FluentAssertions;
using NUnit.Framework;

namespace ArabicToRomanConverterTests
{
    public class Converter_Tests
    {

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(16, "XVI")]
        [TestCase(17, "XVII")]
        [TestCase(18, "XVIII")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        [TestCase(21, "XXI")]
        [TestCase(22, "XXII")]
        [TestCase(23, "XXIII")]
        [TestCase(24, "XXIV")]
        [TestCase(25, "XXV")]
        [TestCase(26, "XXVI")]
        [TestCase(27, "XXVII")]
        [TestCase(28, "XXVIII")]
        [TestCase(29, "XXIX")]
        [TestCase(30, "XXX")]
        [TestCase(31, "XXXI")]
        [TestCase(32, "XXXII")]
        [TestCase(33, "XXXIII")]
        [TestCase(34, "XXXIV")]
        [TestCase(35, "XXXV")]
        [TestCase(36, "XXXVI")]
        [TestCase(37, "XXXVII")]
        [TestCase(38, "XXXVIII")]
        [TestCase(39, "XXXIX")]
        [TestCase(40, "XL")]
        [TestCase(41, "XLI")]
        [TestCase(42, "XLII")]
        [TestCase(43, "XLIII")]
        [TestCase(44, "XLIV")]
        [TestCase(45, "XLV")]
        [TestCase(46, "XLVI")]
        [TestCase(47, "XLVII")]
        [TestCase(48, "XLVIII")]
        [TestCase(49, "XLIX")]
        [TestCase(50, "L")]
        [TestCase(55, "LV")]
        [TestCase(61, "LXI")]
        [TestCase(77, "LXXVII")]
        [TestCase(82, "LXXXII")]
        [TestCase(89, "LXXXIX")]
        [TestCase(90, "XC")]
        [TestCase(99, "XCIX")]
        [TestCase(100, "C")]
        [TestCase(158, "CLVIII")]
        [TestCase(186, "CLXXXVI")]
        [TestCase(200, "CC")]
        [TestCase(333, "CCCXXXIII")]
        [TestCase(400, "CD")]
      

        public void ConvertArabicToRomanNumber(int arabicNumber, string romanNumber)
        {
            // Arrange
            Converter converter = new Converter();

            // Act
            var result = converter.ToRomain(arabicNumber);

            // Assert
            result.Should().Be(romanNumber);
        }

    }
}