using ExpressionMapUtility.ColumnAttributeExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExpressionMapUtility
{
    public class InClass
    { 
     
        public string Name { get; set; }
        public string Description { get; set; }

       
        public double DoubleValue { get; set; }
        public Decimal DecimalValue { get; set; }

       
        public DateTime DateTimeValue { get; set; }
    }
}
