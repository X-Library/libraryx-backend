namespace LibraryX.Api.DataContext;

public class AppDbContext : DbContext
{
    public DbSet<AuthorModel> Authors { get; set; } = null!;
    public DbSet<CategoryModel> Categories { get; set; } = null!;
    public DbSet<BookModel> Books { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=libraryx-dev;User Id=sa;Password=1q2w3e4r@#$");

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new AuthorMapping());
        builder.ApplyConfiguration(new CategoryMapping());
        builder.ApplyConfiguration(new BookMapping());
    }
}