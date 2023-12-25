using UdemyCrack.Core.Entity.Common;

namespace UdemyCrack.DTOs.CategoryDto
{
    public class CategoryUpdateDto:BaseEntity
    {
        public string Title { get; set; }
        public int ParentCategoryId { get; set; }
    }
}
