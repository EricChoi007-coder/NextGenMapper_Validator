using ExpressionMapUtility.Cores;
using System;
using Xunit;

namespace TestExpressionMapUtility
{
    public class ExpressionMappingUnitTest
    {
        [Fact]
        public void ExpressionMappingGenericTest()
        {
            var inClass = new InClass()
            {
                Name = "In_Class_Name",
                Description ="In_Class_Description",
                DoubleValue = 10.9,
                DecimalValue= new decimal(12.9), 
                DateTimeValue = DateTime.Now
            };

            OutClass outClassResult = ExpressionGenericMapper<InClass, OutClass>.Trans(inClass);

            Assert.Equal(outClassResult.Name_Trans , "In_Class_Name");
            Assert.Equal(outClassResult.Description, "In_Class_Description");
            Assert.Equal(outClassResult.Double_Trans, 10.9);
            Assert.Equal(outClassResult.DecimalValue, new decimal(12.9));
        }

        [Fact]
        public void ExpressionMappingDicTest()
        {
            var inClass = new InClass()
            {
                Name = "In_Class_Name",
                Description = "In_Class_Description",
                DoubleValue = 10.9,
                DecimalValue = new decimal(12.9),
                DateTimeValue = DateTime.Now
            };

            OutClass outClassResult = ExpressionDicMapper.Trans<InClass, OutClass>(inClass);


            Assert.Equal(outClassResult.Name_Trans, "In_Class_Name");
            Assert.Equal(outClassResult.Description, "In_Class_Description");
            Assert.Equal(outClassResult.Double_Trans, 10.9);
            Assert.Equal(outClassResult.DecimalValue, new decimal(12.9));
        }
    }
}