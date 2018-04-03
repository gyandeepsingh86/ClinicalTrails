using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalTrail.GeneralObjectStore.Extensions
{
    public static class QueryableExtensions
    {
        /// <summary>
        /// Order the query on field name
        /// </summary>
        /// <typeparam name="TEntity">TEntity</typeparam>
        /// <param name="source">IQueryable source</param>
        /// <param name="fieldName">the name of the field to be sorted on</param>
        /// <param name="orderAscending">Boolean, true = ascending; false = descending</param>
        /// <returns></returns>
        public static IOrderedQueryable<TEntity> Order<TEntity>(this IQueryable<TEntity> source, string fieldName, bool orderAscending) where TEntity : class
        {
            MethodCallExpression callExpression = GenerateMethodCall<TEntity>(source, orderAscending ? "OrderBy" : "OrderByDescending", fieldName);
            return (IOrderedQueryable<TEntity>)source.Provider.CreateQuery(callExpression);
        }

        public static IOrderedQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, string fieldName) where TEntity : class
        {
            MethodCallExpression callExpression = GenerateMethodCall<TEntity>(source, "OrderBy", fieldName);
            return (IOrderedQueryable<TEntity>)source.Provider.CreateQuery(callExpression);
        }

        public static IQueryable<TEntity> OrderByDescending<TEntity>(this IQueryable<TEntity> source, string fieldName) where TEntity : class
        {
            MethodCallExpression callExpression = GenerateMethodCall<TEntity>(source, "OrderByDescending", fieldName);
            return (IQueryable<TEntity>)Expression.Lambda(callExpression).Compile().DynamicInvoke();

        }

        static LambdaExpression GenerateSelector<TEntity>(String propertyName, out Type resultType) where TEntity : class
        {
            ParameterExpression parameter = Expression.Parameter(typeof(TEntity), "Entity");

            //  create the selector part, but support child properties
            PropertyInfo property;
            Expression propertyAccess;
            if (propertyName.Contains('.'))
            {
                // support to be sorted on child fields.
                String[] childProperties = propertyName.Split('.');
                property = typeof(TEntity).GetProperty(childProperties[0]);
                propertyAccess = Expression.MakeMemberAccess(parameter, property);
                for (int i = 1; i < childProperties.Length; i++)
                {
                    property = property.PropertyType.GetProperty(childProperties[i]);
                    propertyAccess = Expression.MakeMemberAccess(propertyAccess, property);
                }
            }
            else
            {
                property = typeof(TEntity).GetProperty(propertyName);
                propertyAccess = Expression.MakeMemberAccess(parameter, property);
            }

            resultType = property.PropertyType;
            return Expression.Lambda(propertyAccess, parameter);
        }

        static MethodCallExpression GenerateMethodCall<TEntity>(IQueryable source, string methodName, String fieldName) where TEntity : class
        {
            Type type = typeof(TEntity);
            Type selectorResultType;
            LambdaExpression selector = GenerateSelector<TEntity>(fieldName, out selectorResultType);
            MethodCallExpression resultExp = Expression.Call(typeof(Queryable), methodName,
                                                             new[] { type, selectorResultType },
                                                             source.Expression, Expression.Quote(selector));
            return resultExp;
        }
    }
}
