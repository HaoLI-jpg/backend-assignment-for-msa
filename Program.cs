var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient("openlibrary", configureClient: client =>
{
    client.BaseAddress = new Uri("https://openlibrary.org/authors/OL23919A.json");
});

ConfigurationManager Configuration = builder.Configuration;

builder.Services.AddHttpClient(Configuration["ClientName"], configureClient: client =>
{
    client.BaseAddress = new Uri(Configuration["Address"]);
});


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
