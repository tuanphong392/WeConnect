var builder = WebApplication.CreateBuilder(args);

// Đăng ký MVC (Controller + View)
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
app.UseRouting();

app.UseAuthorization();

// Phục vụ các file tĩnh trong wwwroot (css, js, images)
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Work}/{action=Index}/{id?}")
    .WithStaticAssets();

// Bất kỳ route không khớp -> trang 404 (giai đoạn 1 chỉ hiển thị giao diện)
app.MapFallbackToController("NotFoundPage", "Home");

app.Run();
