using MeuLivroDeReceitas.Domain.Extension;
using MeuLivroDeReceitas.Infrastructure;
using MeuLivroDeReceitas.Infrastructure.Migrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRepositorio(builder.Configuration);

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

atualizarBaseDeDados();

app.Run();

void atualizarBaseDeDados()
{
    var conexao = builder.Configuration.GetConexao();
    var nomeDataBase = builder.Configuration.GetNomeDataBase();

    DataBase.CriarDataBase(conexao, nomeDataBase);

    app.MigrateBancoDeDados();
}
