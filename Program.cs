
var builder = WebApplication.CreateBuilder(args); 
builder.Services.AddMvc().AddRazorPagesOptions(option =>option.Conventions.AddPageRoute("/Home",""));
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages(); 
app.Run();
