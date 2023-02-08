using Microsoft.EntityFrameworkCore;
using Northwind.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("NW");
builder.Services.AddDbContext<NWContext>(options => options.UseSqlServer(connectionString));
// 1024
//builder.Services.AddDbContextPool<NWContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllersWithViews();
builder.Services.AddMemoryCache();
//builder.Services.AddDistributedMemoryCache();
// SQL Server, Redis, NCache
builder.Services.AddSession(options =>
{
    // Set a short timeout for easy testing. The default is 20 minutes.
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    // Make the session cookie essential
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseStatusCodePages();
//app.UseStatusCodePages(async context => {
//    await context.HttpContext.Response.WriteAsync($"Code: {context.HttpContext.Response.StatusCode}");
//});
app.UseStatusCodePagesWithRedirects("/Home/ErrorStatus?code={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
