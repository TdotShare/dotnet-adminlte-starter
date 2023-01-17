var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Dashboard/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    //endpoints.MapDefaultControllerRoute();

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Dashboard}/{action=Index}/{id?}");

    endpoints.MapGet("/", context =>
    {
        return Task.Run(() => context.Response.Redirect("/dashboard"));
    });
});

/*
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");
*/

app.Run();
