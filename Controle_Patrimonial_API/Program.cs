using Controle_Patrimonial.Application.Service;
using Controle_Patrimonial.Domain.Service;
using Infra.SqlServer;
using Infra.SqlServer.Interfaces;
using Infra.SqlServer.Repositories;

var builder = WebApplication.CreateBuilder(args);


// Injection of Controll
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IPatrimonioRepository, PatrimonioRepository>();
builder.Services.AddScoped<ICheckInRepository, CheckInRepository>();
builder.Services.AddScoped<IBlocoRepository, BlocoRepository>();
builder.Services.AddScoped<ICheckInPatrimonioRepository, CheckInPatrimonioRepository>();

// Injection of Controll Services
builder.Services.AddScoped<EnviarCheckInService, EnviarCheckInService>();
builder.Services.AddScoped<ApplicationServiceEnviarCheckIn, ApplicationServiceEnviarCheckIn>();
builder.Services.AddScoped<Login, Login>();
builder.Services.AddScoped<LoginService, LoginService>();
builder.Services.AddScoped<SqlServerContex, SqlServerContex>();
// Add services to the container.


//Importante para rodar
builder.Services.AddCors();

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddControllers();
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

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});
