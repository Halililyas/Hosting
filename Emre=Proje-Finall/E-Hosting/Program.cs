using DcFramworkCore.DbContext;
using E_Hosting.Extensions;
using Entity.Concreate;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.AddControllersWithViews();




// Identity Projeye Dahil Edilmesi 
builder.Services.AddIdentity<User, IdentityRole>()
				.AddEntityFrameworkStores<Context>()
				.AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
{
	//password
	options.Password.RequireNonAlphanumeric = true;
	options.Password.RequiredLength = 6;
	options.Password.RequireDigit = true;
	options.Password.RequireLowercase = true;
	options.Password.RequireUppercase = true;

	//Her kullanýcý eþsiz bir maile sahip olmalý
	options.User.RequireUniqueEmail = true;
	//
	options.SignIn.RequireConfirmedPhoneNumber = false;
	options.SignIn.RequireConfirmedEmail = false;

});

// Diðer servis konfigürasyonlarý...

builder.Services.AddAuthorization(options =>
{
	options.AddPolicy("User", policy =>
	{
		// Burada "User" politikasýnýn gereksinimleri belirlenir.
		policy.RequireAuthenticatedUser(); // Sadece kimlik doðrulama yapmýþ kullanýcýlara izin verir.
	});
});

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
app.UseAuthentication();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
