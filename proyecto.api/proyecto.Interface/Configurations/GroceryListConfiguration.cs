using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyecto.Core.Entities;

namespace proyecto.Infrastructure.Configurations
{
    class GroceryListConfiguration : IEntityTypeConfiguration<GroceryList>
    {
        public void Configure(EntityTypeBuilder<GroceryList> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasMany(x => x.Items)
                 .WithOne(i => i.GroceryList)
                 .HasForeignKey(i => i.ListId);

        }
    }
}
