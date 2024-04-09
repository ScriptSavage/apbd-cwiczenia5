var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();






app.MapGet("/animals", () =>
{
    // 200 - ok

    // 404 - not found
    return Results.Ok();
});



app.MapGet("/animals/{id}", (int id) =>
{
    return Results.Ok(id);
});


app.MapPost("/animals", () =>
{

});


app.Run();