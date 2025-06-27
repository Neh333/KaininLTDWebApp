using ShopifySharp;
using ShopifySharp.Extensions.DependencyInjection;
//public class DependencyInjectionExample(IServiceCollection services)
//{
//    // ...

//    // Add ShopifySharp's service factories and the LeakyBucketExecutionPolicy to your DI container
//    services.AddShopifySharp<LeakyBucketExecutionPolicy>(options =>
//    {
//        options.RequestExecutionPolicy = new LeakyBucketExecutionPolicy();
//    });
//}


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
