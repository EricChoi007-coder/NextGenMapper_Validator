using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationAttributeUtility.ValidateCore
{
    public abstract class AbstractValidateAttribute: Attribute
    {
        public abstract bool Validate(object value);
    }
}
