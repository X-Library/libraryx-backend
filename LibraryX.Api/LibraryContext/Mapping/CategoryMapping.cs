namespace LibraryX.Api.LibraryContext.Mapping;

public class CategoryMapping : IEntityTypeConfiguration<CategoryModel>
{
    public void Configure(EntityTypeBuilder<CategoryModel> builder)
    {
        builder.ToTable("Category");
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(80)
            .HasColumnType("NVARCHAR");

        builder.Property(x => x.Description)
            .HasColumnType("NVARCHAR(MAX)");
    }
}