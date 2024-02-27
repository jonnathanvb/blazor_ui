using System.Reflection;

namespace app.Extension
{
    public static class PropertyExtension
    {
        public static T? GetAttribute<T>(this PropertyInfo value)
        {
            var list = value.GetCustomAttributes(typeof(T), false).ToList();
            return (T?) (list.Count == 0 ? null : list.FirstOrDefault());

        }

       

       
    }
}
