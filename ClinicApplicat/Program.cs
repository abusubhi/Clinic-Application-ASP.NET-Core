using Clinic.Infrastructire.Data;
using Clinic.Service;
using Clinic.Service.Abstracts;
using Clinic.Service.Implementation;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>
    (Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDb")));




#region Dependancy injection

builder.Services
    .AddServiceDependancies();

#endregion 
//builder.Services.AddScoped<IPatientService, PatientServices>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//app.UseMvc();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Patient}/{action=Index}/{id?}");



app.Run();
