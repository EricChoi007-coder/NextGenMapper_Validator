using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionMapUtility.ColumnAttributeExtension
{
    public static class ColumnAttributeHelper
    {
        public static string GetPropertyName(this PropertyInfo prop)
        {
            if (prop.IsDefined(typeof(ColumnAttribute), true))
            {
                ColumnAttribute columnAttribute = (ColumnAttribute)prop.GetCustomAttribute(typeof(ColumnAttribute), true);
                return columnAttribute.GetColumnName();
            }
            else 
            {
                return prop.Name;
            }
        }

        public static string GetFieldName(this FieldInfo field)
        {
            if (field.IsDefined(typeof(ColumnAttribute), true))
            {
                ColumnAttribute columnAttribute = (ColumnAttribute)field.GetCustomAttribute(typeof(ColumnAttribute), true);
                return columnAttribute.GetColumnName();
            }
            else
            {
                return field.Name;
            }
        }
    }
}
