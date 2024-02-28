using app.Attributes;
using app.Services.Dto;
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

       
        public static string GetColumnName(this PropertyInfo value)
        {
            var attribute = value.GetAttribute<TableColumnAttribute>();
            if (attribute == null) return value.Name;

            return attribute.NameColumn;
        }

        public static bool IsVisible(this PropertyInfo value)
        {
            var attribute = value.GetAttribute<TableColumnAttribute>();
            if (attribute == null) return true;

            return attribute.IsVisible;
        }


    }
}
