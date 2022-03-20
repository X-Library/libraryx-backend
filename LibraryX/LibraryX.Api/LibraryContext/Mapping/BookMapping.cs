namespace LibraryX.Api.LibraryContext.Mapping;

public class BookMapping : IEntityTypeConfiguration<BookModel>
{
    public void Configure(EntityTypeBuilder<BookModel> builder)
    {
        builder.ToTable("Book");
        
        // Keys & Indexes
        builder.HasKey(x => x.Id);
        
        // Relationships
        builder.HasOne(x => x.Author);
        builder.HasOne(x => x.Category);
        
        // Class Properties
        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(80)
            .HasColumnType("NVARCHAR");
        
        builder.Property(x => x.Description)
            .HasColumnType("NVARCHAR");
        
        builder.Property(x => x.Summary)
            .HasColumnType("NVARCHAR");

        builder.Property(x => x.ISSN)
            .IsRequired()
            .HasMaxLength(13)
            .HasColumnType("VARCHAR");
    }
}