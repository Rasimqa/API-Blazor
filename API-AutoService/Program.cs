
using API_BlazorForSome.DBContext;
using API_BlazorForSome.Interfaces;
using API_BlazorForSome.Service;
using API_BlazorForSome.DBContext;
using API_BlazorForSome.Interfaces;
using API_BlazorForSome.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();


builder.Services.AddDbContext<ArmyPetServiceDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TestDbString")), ServiceLifetime.Scoped);

builder.Services.AddScoped<ISpacesService, SpaceService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IWorkPlacesService, WorkPlacesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();

}
app.UseCors("AllowAllOrigins");




app.UseRouting();



app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
