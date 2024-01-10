using DresselZFivetoSevenEndpoints.Services.MadLib;
using DresselZFivetoSevenEndpoints.Services.MadLib.OddorEven;
using DresselZFivetoSevenEndpoints.Services.OddorEven;
using DresselZFivetoSevenEndpoints.Services.ReverseItAlpha;
using DresselZFivetoSevenEndpoints.Services.ReverseItNum;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddorEvenService, OddorEvenService>();
builder.Services.AddScoped<IReverseItAlphaService, ReverseItAlphaService>();
builder.Services.AddScoped<IReverseItNumService, ReverseItNumService>();


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
