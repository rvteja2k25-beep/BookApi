using BookApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddSingleton<BookService>();
builder.Services.AddControllers();

// Build the app
var app = builder.Build();

// Map controllers
app.MapControllers();

// Do NOT call app.Run() in Lambda
// app.Run();

