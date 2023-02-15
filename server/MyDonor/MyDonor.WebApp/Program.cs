
using MyDonor.service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var Connstr = builder.Configuration.GetConnectionString("DefaultConnections");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(Connstr);
});
builder.Services.AddScoped<BloodGroupService>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
