using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebComplejoDeportivo_MCV.Data;
using WebComplejoDeportivo_MCV.Models;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// REGISTRO DEL DBCONTEXT EN DEPENDENCIAS
builder.Services.AddDbContext<ComplejoDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ComplejoDbContext")
    ));



// ==================== IDENTITY ====================
// Configura el sistema de usuarios, inicio de sesión y roles.

builder.Services.AddDefaultIdentity<Usuario>(options =>
{
    // Permite iniciar sesión sin tener que confirmar la cuenta por email.
    options.SignIn.RequireConfirmedAccount = false;

    // La contraseña no necesita caracteres especiales como @, #, $, etc.
    options.Password.RequireNonAlphanumeric = false;

    // ==================== CONFIGURACIÓN DE PASSWORD ====================

    // Mínimo 8 caracteres
    options.Password.RequiredLength = 8;

    // Obliga a tener al menos un número
    options.Password.RequireDigit = true;

    // Obliga a tener al menos una letra minúscula
    options.Password.RequireLowercase = true;

    // No obliga a tener una letra mayúscula
    options.Password.RequireUppercase = false;

    // No obliga a usar caracteres especiales (@, #, $, etc.)
    options.Password.RequireNonAlphanumeric = false;

    // Cantidad mínima de caracteres diferentes dentro de la contraseña
    options.Password.RequiredUniqueChars = 1;



    // ==================== CONFIGURACIÓN DE SIGN IN ====================

    // No requiere confirmar la cuenta ni el email para iniciar sesión
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;

    // No requiere confirmar teléfono
    options.SignIn.RequireConfirmedPhoneNumber = false;



    // ==================== BLOQUEO DE USUARIO ====================

    // Si se bloquea la cuenta, el bloqueo dura 15 minutos
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);

    // Después de 5 intentos fallidos de inicio de sesión, bloquea la cuenta
    options.Lockout.MaxFailedAccessAttempts = 5;

    // Permite que los usuarios nuevos también puedan ser bloqueados
    options.Lockout.AllowedForNewUsers = true;

})
    // Habilita el manejo de roles (Administrador, Empleado, Cliente, etc.).
    .AddRoles<IdentityRole>()

    // Indica que Identity guardará usuarios y roles en la BD
    // utilizando Entity Framework y nuestro ComplejoDbContext.
    .AddEntityFrameworkStores<ComplejoDbContext>();


// ==================== COOKIE DE IDENTITY ====================
// Configura la cookie que mantiene al usuario logueado.

builder.Services.ConfigureApplicationCookie(o =>
{
    // La sesión/cookie vence después de 60 minutos
    o.ExpireTimeSpan = TimeSpan.FromMinutes(60);

    // Si el usuario sigue usando el sistema,
    // se va renovando el tiempo de la cookie.
    o.SlidingExpiration = true;

    // Si intenta entrar a una página que requiere estar logueado,
    // lo manda al Login.
    o.LoginPath = "/Identity/Account/Login";

    // Si está logueado pero NO tiene permiso para entrar,
    // lo manda a AccessDenied.
    o.AccessDeniedPath = "/Identity/Account/AccessDenied";
});


// Habilita Razor Pages.
// Identity utiliza Razor Pages para Login, Register, Logout, etc.
builder.Services.AddRazorPages();






var app = builder.Build();



// Creamos un scope para poder obtener el DbContext
using (var scope = app.Services.CreateScope())
{
    // Obtenemos el DbContext desde la inyección de dependencias
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ComplejoDbContext>();

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


// ==================== IDENTITY ====================
// Comprueba quién es el usuario que inició sesión.
app.UseAuthentication();

// Comprueba qué permisos/roles tiene ese usuario.
app.UseAuthorization();


app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


// ==================== IDENTITY - RAZOR PAGES ====================
// Habilita las páginas que utiliza Identity,
// como Login, Register, Logout, etc.
app.MapRazorPages();


app.Run();
