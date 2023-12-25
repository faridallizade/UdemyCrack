using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UdemyCrack.Models;

namespace UdemyCrack.Confriguration
{
    public class CategoryConfriguration
    {
        public class CategoryConfiguration : IEntityTypeConfiguration<Category>
        {
            public void Configure(EntityTypeBuilder<Category> builder)
            {
                builder.Property(x => x.Title).IsRequired().HasMaxLength(65);
                builder.HasOne(x => x.ParentCategory).WithMany(x => x.ChildCategories).HasForeignKey(x => x.ParentCategoryId).OnDelete(DeleteBehavior.Restrict);
                builder.HasMany(x => x.ChildCategories).WithOne(x => x.ParentCategory).HasForeignKey(x => x.ParentCategoryId).OnDelete(DeleteBehavior.Restrict);
            }
        }
    }
}
