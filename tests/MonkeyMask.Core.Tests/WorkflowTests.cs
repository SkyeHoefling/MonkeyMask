using NUnit.Framework;

namespace MonkeyMask.Core.Tests
{
    [TestFixture]
    public class WorkflowTests
    {
        [Test]
        public void SimpleEntryFieldTest()
        {
            var format = "##-##";
            var input = string.Empty;

            var result = MonkeyEntry.Mask(input, format);
            Assert.IsEmpty(result);

            input = result + "1";
            result = MonkeyEntry.Mask(input, format);
            Assert.IsNotEmpty(result);
            Assert.AreEqual("1", result);

            input = result + "1";
            result = MonkeyEntry.Mask(input, format);
            Assert.IsNotEmpty(result);
            Assert.AreEqual("11-", result);

            input = result + "1";
            result = MonkeyEntry.Mask(input, format);
            Assert.IsNotEmpty(result);
            Assert.AreEqual("11-1", result);

            input = result + "1";
            result = MonkeyEntry.Mask(input, format);
            Assert.IsNotEmpty(result);
            Assert.AreEqual("11-11", result);
        }
    }
}
