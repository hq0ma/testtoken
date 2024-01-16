using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NotificationMessage.Backend.DataContext;
using NotificationMessage.Backend.Mapper;
using NotificationMessage.Backend.Service;
using OfficeOpenXml;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//#################### MyService #########################
//connection string
builder.Services.AddDbContext<MyAppDbContext2024>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
//Mapper
builder.Services.AddAutoMapper(typeof(MapperProfile));
//Excel File Manager
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
//Edit datetime Npgsql
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
//Diseble Cross-Origin
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});
//Jwt
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => {
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});
//Service
builder.Services.AddScoped<UserService, UserService>();
//#################### MyService #########################
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseRouting();
app.UseCors("AllowAnyOrigin");
app.MapControllers();

app.Run();
