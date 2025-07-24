using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BookShop.Models.Entities;


namespace BookShop.Models.Configurations
{
    public class  CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", "MasterSchema");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.CatName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.CatOrder)
                .IsRequired();

            builder.Ignore(c => c.CreatedDate);

            builder.Property(c => c.IsDeleted)
                   .HasColumnName("isDeleted");
        }

    }
}
