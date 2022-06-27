using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationAttributeUtility.ValidateCore.ImpleAttriRules
{
    public class EmailAttribute : AbstractValidateAttribute
    { 
        public override bool Validate(object value)
        {
            return value != null
                && Regex.IsMatch(value.ToString(), @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }
    }
}
