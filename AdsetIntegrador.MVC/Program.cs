using AdsetIntegrador.MVC.AutoMapper;
using AdsetIntegrator.Application;
using AdsetIntegrator.Application.Interface;
using AdsetIntegrator.Domain.Interfaces.Repositories;
using AdsetIntegrator.Domain.Interfaces.Services;
using AdsetIntegrator.Domain.Services;
using AdsetIntegrator.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<typeof(IAppServiceBase<>), typeof(AppServiceBase<>)>

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IVeiculoAppService, VeiculoAppService>();
builder.Services.AddTransient<IVeiculoService, VeiculoService>();
builder.Services.AddTransient<IVeiculoRepository, VeiculoRepository>();
AutoMapperConfig.RegisterMappings();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Veiculo}/{action=Index}/{id?}");

app.Run();


