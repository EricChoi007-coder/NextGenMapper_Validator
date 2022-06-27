using ValidationAttributeUtility.ValidateCore;
using Xunit;

namespace TestValidationUtility
{
    public class UnitTest1
    {
        [Fact]
        public void TestValidation()
        {
            var validateClass = new BusinessClass()
            {
                TelNo = "13952847328",
                TelDesc = "property",
                Email = "jack@google.com",
                endPoint = "https://www.baidu.com"
            };

            Assert.True(validateClass.NextGenValidate<BusinessClass>());
        }
    }
}