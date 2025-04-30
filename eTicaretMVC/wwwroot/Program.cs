var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

// Custom routes for eTicaretMVC
app.MapControllerRoute(
    name: "productDetail",
    pattern: "product/{categoryName}-{title}-{id}/details",
    defaults: new { controller = "Home", action = "ProductDetail" });

app.MapControllerRoute(
    name: "aboutUs",
    pattern: "about-us",
    defaults: new { controller = "Home", action = "AboutUs" });

app.MapControllerRoute(
    name: "orderDetails",
    pattern: "order/{id}/details",
    defaults: new { controller = "Order", action = "Details" });

// Default route (already exists, kept as is)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();