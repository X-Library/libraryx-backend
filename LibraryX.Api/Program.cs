var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();


app.MapGet("/v1/authors", (AppDbContext context) =>
{
    var authors = context.Authors.ToList();
    return Results.Ok(authors);
});

app.MapPost("/v1/authors", (
    AppDbContext context,
    AuthorModel author) =>
{
    context.Authors.Add(author);
    context.SaveChanges();

    Results.Ok($"Autor {author.Name} {author.LastName} cadastrado com sucesso.");
});

app.MapDelete("/v1/authors/{id}", (
    AppDbContext context,
    string id) =>
{
    var authorId = new Guid(id);
    var author = context.Authors.Find(authorId);
    context.Authors.Remove(author);
    context.SaveChanges();

    Results.Ok($"Autor {author.Name} {author.LastName} removido com sucesso.");
});

app.MapPut("/v1/authors/{id}", (
    AppDbContext context,
    AuthorModel author) =>
{
    context.Authors.Update(author);
    context.SaveChanges();

    Results.Ok($"Informações do autor {author.Name} {author.LastName} atualizadas com sucesso.");
});

app.MapGet("/v1/category", (AppDbContext context) =>
{
    var categories = context.Categories.ToList();
    return Results.Ok(categories);
});

app.MapPost("/v1/category", (
    AppDbContext context,
    CategoryModel category) =>
{
    context.Categories.Add(category);
    context.SaveChanges();

    Results.Ok($"Category {category.Title} {category.Description} cadastrado com sucesso.");
});

app.MapDelete("/v1/category/{id}", (
    AppDbContext context,
    string id) =>
{
    var categoryId = new Guid(id);
    var category = context.Categories.Find(categoryId);
    context.Categories.Remove(category);
    context.SaveChanges();

    Results.Ok($"Autor {category.Title} {category.Description} removido com sucesso.");
});

app.MapPut("/v1/category/{id}", (
    AppDbContext context,
    CategoryModel category) =>
{
    context.Categories.Update(category);
    context.SaveChanges();

    Results.Ok($"Informações do autor {category.Title} {category} atualizadas com sucesso.");
});

app.Run();
