using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationAttributeUtility.Model;
using ValidationAttributeUtility.ValidateCore.ImpleAttriRules;

namespace TestValidationUtility
{
    public class BusinessClass: BaseValidateModel
    {
        [Mobile]
        public string TelNo { get; set; }
        [Leng(4,10)]
        public string TelDesc { get; set; }
        [Email]
        public string Email { get; set; }

      //  [Regex("")]
        public string endPoint { get; set; }
    }
}
