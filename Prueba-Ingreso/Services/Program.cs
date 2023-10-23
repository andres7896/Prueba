using DataAccess.Context;
using DataAccess.Empleados;
using DataLogic.Empleados;

var builder = WebApplication.CreateBuilder(args);

//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
                   .AllowAnyHeader()
                   .AllowCredentials()
                   .AllowAnyMethod();
        });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Scoped - Alcances
builder.Services
       .AddDbContext<DbConnection>()
       .AddTransient<EmpleadosMetodos>()
       .AddTransient<EmpleadosLogica>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseAuthorization();
app.UseCors("AllowOrigin");
app.MapControllers();

app.Run();
