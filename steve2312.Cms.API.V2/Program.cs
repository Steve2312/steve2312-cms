using System.Reflection;
using Microsoft.EntityFrameworkCore;
using steve2312.Cms.API.V2.Repositories;
using steve2312.Cms.API.V2.Services;
using steve2312.Cms.DAL.V2;
using steve2312.Cms.DAL.V2.Models;
using steve2312.Cms.DAL.V2.Models.KeyFields;
using steve2312.Cms.DAL.V2.Models.ValueFields;

var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING") ??
                       throw new InvalidOperationException("CONNECTION_STRING");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Services
builder.Services.AddScoped<IModelService, ModelService>();
builder.Services.AddScoped<IEntityService, EntityService>();
builder.Services.AddScoped<ISerializationService, SerializationService>();

// Repositories
builder.Services.AddScoped<IModelRepository, ModelRepository>();
builder.Services.AddScoped<IEntityRepository, EntityRepository>();


// Context
builder.Services.AddDbContext<CmsDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var name = Assembly.GetExecutingAssembly().GetName().Name;
    var path = Path.Combine(AppContext.BaseDirectory, $"{name}.xml");
    
    options.IncludeXmlComments(path);
});

var app = builder.Build();

// Remove in production
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetService<CmsDbContext>();

    context?.Database.EnsureDeleted();
    context?.Database.EnsureCreated();

    var model = new Model
    {
        Name = "song",
    };

    var titleKey = new StringKeyField
    {
        Key = "title",
        Model = model,
    };

    var durationKey = new IntegerKeyField
    {
        Key = "duration",
        Model = model,
    };

    var instance = new Entity
    {
        Name = "Bubble Gum - New Jeans",
        Model = model,
    };

    var titleValue = new StringValueField
    {
        Value = "Bubble Gum",
        StringKeyField = titleKey,
        Entity = instance
    };
    
    var durationValue = new IntegerValueField
    {
        Value = 120,
        IntegerKeyField = durationKey,
        Entity = instance
    };

    context?.Models.Add(model);
    context?.Entities.Add(instance);
    
    context?.StringKeyFields.Add(titleKey);
    context?.IntegerKeyFields.Add(durationKey);
    
    context?.StringValueFields.Add(titleValue);
    context?.IntegerValueFields.Add(durationValue);

    context?.SaveChanges();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();