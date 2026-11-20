using DN_9.Data;
var builder=WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<PlacementRepository>();
var app=builder.Build();
PlacementDb.Initialize();
if(!app.Environment.IsDevelopment()){app.UseExceptionHandler("/Placement/Index");app.UseHsts();}
app.UseStaticFiles();app.UseRouting();app.UseAuthorization();
app.MapControllerRoute(name:"default",pattern:"{controller=Placement}/{action=Index}/{id?}");
app.Run();