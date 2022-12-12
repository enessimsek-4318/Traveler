using BLL.Abstract;
using BLL.Concrete;
using DAL.Abstract;
using DAL.Concrete;
using Traveler.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest);
builder.Services.AddScoped<IAdminDAL, AdminDAL>();
builder.Services.AddScoped<IAdminService, AdminManager>();
builder.Services.AddScoped<IPostDAL, PostDAL>();
builder.Services.AddScoped<IPostService, PostManager>();
builder.Services.AddScoped<IUserDAL, UserDAL>();
builder.Services.AddScoped<IUserService, UserManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.CustomStaticFiles();

app.UseRouting();

app.UseAuthorization(); 

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Login}/{action=LoginCheck}");
});
SeedDatabase.Seed();
app.Run();
