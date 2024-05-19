using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IT_WEB_23_63_0055_K.H.S.D.Hettiarachchi_Q2.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context") ?? throw new InvalidOperationException("Connection string 'IT_WEB_23_63_0055_KHSDHettiarachchi_Q2Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
