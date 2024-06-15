using System.Reflection;
using Microsoft.EntityFrameworkCore;
using steve2312.Cms.API.V2.Repositories;
using steve2312.Cms.API.V2.Services;
using steve2312.Cms.DAL.V2;
using steve2312.Cms.DAL.V2.Models;

var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING") ??
                       throw new InvalidOperationException("CONNECTION_STRING");

var allowOrigin = Environment.GetEnvironmentVariable("ALLOW_ORIGIN") ??
                       throw new InvalidOperationException("ALLOW_ORIGIN");

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

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("cors", policy =>
    {
        policy
            .WithOrigins(allowOrigin)
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
    builder.Services.AddLogging();
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
        Name = "Song",
    };

    var titleKey = new KeyField<string>
    {
        Key = "title",
        Model = model,
        Required = true,
    };

    var durationKey = new KeyField<int>
    {
        Key = "duration",
        Model = model,
        Required = true,
    };

    var instance = new Entity
    {
        Name = "Bubble Gum - New Jeans",
        Model = model,
    };

    var titleValue = new ValueField<string>
    {
        Value = "Bubble Gum",
        KeyField = titleKey,
        Entity = instance
    };
    
    var durationValue = new ValueField<int>
    {
        Value = 120,
        KeyField = durationKey,
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

app.UseCors("cors");

app.MapControllers();

app.Run();