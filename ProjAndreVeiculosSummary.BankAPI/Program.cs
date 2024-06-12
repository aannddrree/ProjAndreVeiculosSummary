using Microsoft.Extensions.Options;
using ProjAndreVeiculosSummary.BankAPI.Services;
using ProjAndreVeiculosSummary.BankAPI.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurações para receber os dados do arquivo de configuração 
builder.Services.Configure<ProjAndreVeiculosSummarySettings>(
    builder.Configuration.GetSection(nameof(ProjAndreVeiculosSummarySettings)));

builder.Services.AddSingleton<IProjAndreVeiculosSummarySettings>(
        sp => sp.GetRequiredService<IOptions<ProjAndreVeiculosSummarySettings>>().Value);

builder.Services.AddSingleton<BankService>();

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
