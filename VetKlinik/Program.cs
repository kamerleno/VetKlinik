var builder = WebApplication.CreateBuilder(args); 
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


var app = builder.Build(); //uygulama başlatılıyor

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();//http yi https ye yönlendiriyor
app.UseRouting();// hangi controllere gideceği

app.UseAuthorization();// kim olduğunu anlamak için

app.MapStaticAssets();//statik dosyaları kullanmak için wwwroot gibi

app.MapControllerRoute(//varsayılan route ayarları
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages()
   .WithStaticAssets();

app.Run();//sunucuyu çalıştırıyor istekleri dinlemeye başlıyor
