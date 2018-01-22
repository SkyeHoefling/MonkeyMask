using NUnit.Framework;

namespace MonkeyMask.Core.Tests
{
    [TestFixture]
    public class MonkeyEntryTests
    {
        [Test]
        public void MaskInput_Where_FormatLength_is_Equal()
        {
            var input = "1234";
            var format = "##-##";
            var result = MonkeyEntry.Mask(input, format);

            Assert.IsNotEmpty(result);
            Assert.AreEqual("12-34", result);
        }

        [Test]
        public void MaskInput_Where_FormatLength_is_Greater()
        {
            var input = "123";
            var format = "##-##-##";
            var result = MonkeyEntry.Mask(input, format);

            Assert.IsNotEmpty(result);
            Assert.AreEqual("12-3", result);
        }

        [Test]
        public void MaskInput_Where_FormatLength_is_Greater_And_DisplayTrailingFormatting()
        {
            var input = "123456";
            var format = "##-##-##-##";
            var result = MonkeyEntry.Mask(input, format);

            Assert.IsNotEmpty(result);
            Assert.AreEqual("12-34-56-", result);
        }

        [Test]
        public void MaskInput_Where_Input_is_Empty()
        {
            // TODO: Add your test code here
            var input = "";
            var format = "##-##";
            var result = MonkeyEntry.Mask(input, format);

            Assert.IsEmpty(result);
        }

        [Test]
        public void MaskInput_Where_Input_is_Null()
        {
            string input = null;
            var format = "##-##";
            var result = MonkeyEntry.Mask(input, format);

            Assert.IsEmpty(result);
        }

        [Test]
        public void MaskInput_Where_Format_is_Empty()
        {
            var input = "1234";
            var format = string.Empty;
            var result = MonkeyEntry.Mask(input, format);

            Assert.IsNotEmpty(result);
            Assert.AreEqual(input, result);
        }

        [Test]
        public void MaskInput_Where_Format_is_Null()
        {
            var input = "1234";
            string format = null;
            var result = MonkeyEntry.Mask(input, format);

            Assert.IsNotEmpty(result);
            Assert.AreEqual(input, result);
        }

        [Test]
        public void MaskInput_Where_InputLength_is_Greater_MaxLength()
        {
            var input = "12345";
            var format = "##-##";
            var result = MonkeyEntry.Mask(input, format, 4);
        }

        [Test]
        public void MaskInput_Where_InputLength_is_Greater_FormatLength()
        {
            // TODO             
        }
    }
}
