var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // 👈 IMPORTANTE
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers(); // 👈 IMPORTANTE

app.Run();