using Microsoft.EntityFrameworkCore;
using WebComplejoDeportivo_MCV.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// REGISTRO DEL DBCONTEXT EN DEPENDENCIAS
builder.Services.AddDbContext<ComplejoDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ComplejoDbContext")
    ));


var app = builder.Build();

// Creamos un scope para poder obtener el DbContext
using (var scope = app.Services.CreateScope())
{
    // Obtenemos el DbContext desde la inyección de dependencias
    var context = scope.ServiceProvider
                       .GetRequiredService<ComplejoDbContext>();

    // Ejecutamos los datos iniciales
    DbSeeder.Seed(context);
}




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
