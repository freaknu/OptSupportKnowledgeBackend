using KnowledgeBaseAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddDbContext<KnowledgeBaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactFrontend",
        policy => policy.WithOrigins("http://localhost:5173")
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});


builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<KnowledgeBaseContext>();
    DbInitializer.Initialize(context);
}


if (app.Environment.IsDevelopment())
{

}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("AllowReactFrontend");
app.UseAuthorization();
app.MapControllers();

app.Run();