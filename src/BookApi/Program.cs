using BookApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BookDb>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");

app.Run();
