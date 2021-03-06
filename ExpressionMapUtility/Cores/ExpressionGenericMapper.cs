using ExpressionMapUtility.ColumnAttributeExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionMapUtility.Cores
{
    public class ExpressionGenericMapper<TIn, TOut>
    {
        //看到這裏，不要迷戀哥，哥只是個傳説
        //Generic Cache for Mapping 
        private static Func<TIn, TOut> _FUNC = null;
        static ExpressionGenericMapper()
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(TIn), "p");
            List<MemberBinding> memberBindingList = new List<MemberBinding>();

            foreach (var item in typeof(TOut).GetProperties())
            {
               MemberExpression property = Expression.Property(parameterExpression, typeof(TIn).GetProperty(item.GetPropertyName()));
               // MemberExpression property = Expression.Property(parameterExpression, typeof(TIn).GetProperty(item.Name));
                MemberBinding memberBinding = Expression.Bind(item, property);
                memberBindingList.Add(memberBinding);
            }
            foreach (var item in typeof(TOut).GetFields())
            {
                MemberExpression property = Expression.Field(parameterExpression, typeof(TIn).GetField(item.GetFieldName()));
              //  MemberExpression property = Expression.Field(parameterExpression, typeof(TIn).GetField(item.Name));
                MemberBinding memberBinding = Expression.Bind(item, property);
                memberBindingList.Add(memberBinding);
            }
            MemberInitExpression memberInitExpression = Expression.MemberInit(Expression.New(typeof(TOut)), memberBindingList.ToArray());
            Expression<Func<TIn, TOut>> lambda = Expression.Lambda<Func<TIn, TOut>>(memberInitExpression, new ParameterExpression[]
            {
                    parameterExpression
            });
            _FUNC = lambda.Compile();//one-time
        }
        public static TOut Trans(TIn t)
        {
            return _FUNC(t);
        }
    }
}
