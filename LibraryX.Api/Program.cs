var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();
app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        "areas",
        "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapGet("/v1/category", (AppDbContext context) =>
{
    var categories = context.Categories.ToList();
    return Results.Ok(categories);
});

app.MapGet("/v1/category/{id}", (
    AppDbContext context,
    string id) =>
{
    var categoryId = new Guid(id);
    var category = context.Categories.Find(categoryId);
    return Results.Ok(category);
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
