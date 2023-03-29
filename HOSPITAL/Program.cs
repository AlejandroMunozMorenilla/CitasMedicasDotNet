using Hospital.Repository;
using HOSPITAL.Data;
using HOSPITAL.Interfaces;
using HOSPITAL.Mappers;
using HOSPITAL.Repositories;
using HOSPITAL.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Mapper
builder.Services.AddAutoMapper(typeof(AutoMappers).Assembly);

//DB CONTEXT
var connectionStringOHospital = builder.Configuration.GetConnectionString("HospitalConnection");
builder.Services.AddDbContext<HospitalContext>(options =>
    options.UseSqlServer(connectionStringOHospital));

//Repository layer
builder.Services.AddScoped(typeof(IDiagnosticoRepository), typeof(DiagnosticoRepository));
builder.Services.AddScoped(typeof(ICitaRepository), typeof(CitaRepository));
builder.Services.AddScoped(typeof(IMedicoRepository), typeof(MedicoRepository));
builder.Services.AddScoped(typeof(IPacienteRepository), typeof(PacienteRepository));


//Sevice layer
builder.Services.AddScoped(typeof(IDiagnosticoService), typeof(DiagnosticoService));
builder.Services.AddScoped(typeof(ICitaService), typeof(CitaService));
builder.Services.AddScoped(typeof(IMedicoService), typeof(MedicoService));
builder.Services.AddScoped(typeof(IPacienteService), typeof(PacienteService));


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
