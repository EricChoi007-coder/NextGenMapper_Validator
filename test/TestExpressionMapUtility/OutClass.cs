using ExpressionMapUtility.ColumnAttributeExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExpressionMapUtility
{
    internal class OutClass
    {
        [Column("Name")]
        public string Name_Trans { get; set; }
        public string Description { get; set; }
        [Column("DoubleValue")]
        public double Double_Trans { get; set; }
        public Decimal DecimalValue { get; set; }
        [Column("DateTimeValue")]
        public DateTime DataTime_Trans { get; set; }
    }
}
