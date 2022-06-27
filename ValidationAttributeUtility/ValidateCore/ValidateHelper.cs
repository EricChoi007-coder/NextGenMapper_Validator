using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationAttributeUtility.Model;

namespace ValidationAttributeUtility.ValidateCore
{
    public static class ValidateHelper
    {
        public static bool NextGenValidate<T>(this T tModel) where T : BaseValidateModel
        {
            Type type = tModel.GetType();
            foreach (var prop in type.GetProperties())
            {
                if (prop.IsDefined(typeof(AbstractValidateAttribute), true))
                {
                    object[] attributeArray = prop.GetCustomAttributes(typeof(AbstractValidateAttribute), true);
                    foreach (AbstractValidateAttribute attribute in attributeArray)
                    {
                        if (!attribute.Validate(prop.GetValue(tModel)))
                        {
                           // return false;
                            throw new Exception($"{prop.Name}property_value_of:{prop.GetValue(tModel)}is incorrect");
                        }
                    }
                }
            }
            foreach (var field in type.GetFields())
            {
                if (field.IsDefined(typeof(AbstractValidateAttribute), true))
                {
                    object[] attributeArray = field.GetCustomAttributes(typeof(AbstractValidateAttribute), true);
                    foreach (AbstractValidateAttribute attribute in attributeArray)
                    {
                        if (!attribute.Validate(field.GetValue(tModel)))
                        {
                            // return false;
                            throw new Exception($"{field.Name}field_value_of:{field.GetValue(tModel)}is incorrect");
                        }
                    }
                }
            }
            return true;
        }
    }
}
