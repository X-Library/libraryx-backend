namespace LibraryX.Api.LibraryContext.Mapping;

public class AuthorMapping : IEntityTypeConfiguration<AuthorModel>
{
    public void Configure(EntityTypeBuilder<AuthorModel> builder)
    {
        builder.ToTable("Author");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(80)
            .HasColumnType("NVARCHAR");

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(80)
            .HasColumnType("NVARCHAR");

        builder.Property(x => x.Nationality)
            .IsRequired()
            .HasMaxLength(80)
            .HasColumnType("VARCHAR");

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(160)
            .HasColumnType("VARCHAR");
    }
}