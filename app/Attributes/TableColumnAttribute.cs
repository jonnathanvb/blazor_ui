namespace app.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TableColumnAttribute : Attribute
    {
        public String NameColumn { get; set; }
        public bool IsVisible { get; set; }

        public TableColumnAttribute(string nameColumn, bool isVisible = true)
        {
            NameColumn = nameColumn;
            IsVisible = isVisible;
        }
  
    }
}
