
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRandomNumberService, RandomNumber>();
builder.Services.AddScoped<IRandomNumberService2, RandomNumber2>();

//builder.Services.AddTransient<IRandomNumberService, RandomNumber>(); //Always different number!
//builder.Services.AddSingleton<IRandomNumberService, RandomNumber>(); //Alway same number!

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
