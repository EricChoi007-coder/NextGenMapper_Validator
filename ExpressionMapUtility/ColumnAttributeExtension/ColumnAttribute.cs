using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionMapUtility.ColumnAttributeExtension
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ColumnAttribute:Attribute
    {
        private string _Name = null;
        public ColumnAttribute(string name) 
        {
        this._Name = name;
        }

        public string GetColumnName()
        { 
        return this._Name;
        }
    }
}
