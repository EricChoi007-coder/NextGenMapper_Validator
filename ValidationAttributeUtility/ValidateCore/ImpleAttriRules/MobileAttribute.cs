using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationAttributeUtility.ValidateCore.ImpleAttriRules
{
    public class MobileAttribute : AbstractValidateAttribute
    {
        public override bool Validate(object value)
        {
            if (value == null)
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(value.ToString(), @"^[1]+[3,5]+\d{9}");
            }
        }
    }
}
