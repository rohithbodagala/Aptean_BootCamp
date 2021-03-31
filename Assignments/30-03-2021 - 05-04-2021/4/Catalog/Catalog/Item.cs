using System;
public enum Category
{
    Music,
    Film,
    ComputerProgram
}
namespace Catalog
{
    public class Item
    {
        string Name,Code;
        double Size;
        Category category;
        
        public Item(string Name,string Code,Category category,double Size)
        {
            this.Name = Name;
            this.Code = Code;
            this.category = category;
            this.Size = Size;
        }
        public virtual string RetrieveInformation()
        {
            return $"Name:{Name}\nCode:{Code}\nCategory:{category}\nSize:{Size}MB\n";
        }
    }
}