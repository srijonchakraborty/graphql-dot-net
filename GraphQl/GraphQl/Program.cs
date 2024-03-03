using Common.Model.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGraphQLServer();
builder.Services.AddControllers();

#region App Settings
var appSettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseAuthorization();

app.MapGraphQL();

app.MapControllers();

app.Run();
