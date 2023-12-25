using UdemyCrack.Core.Entity.Common;

namespace UdemyCrack.Models
{
    public class Category :BaseAuditable
    {
        public string Title { get; set; }
        public int? ParentCategoryId {  get; set; }
        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Category> ChildCategories { get; set; }
    }
}
