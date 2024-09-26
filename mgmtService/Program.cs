using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer(); // Builder is a add Reference to dotnet
builder.Services.AddSwaggerGen();
builder.Services.AddControllers(); // Add Reference
builder.Services.AddCors(Opt=>
{
    Opt.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.WithOrigins("https://localhost:4200")

                
               .AllowAnyHeader()                  
               .AllowAnyMethod();                  
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers(); // In-Built Middleware
app.UseCors("CorsPolicy"); 
app.Run();

