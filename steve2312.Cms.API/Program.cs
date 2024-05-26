using Microsoft.EntityFrameworkCore;
using steve2312.Cms.API.Repositories;
using steve2312.Cms.API.Services;
using steve2312.Cms.DAL;
using steve2312.Cms.DAL.Models;
using steve2312.Cms.DAL.Models.KeyFields;
using steve2312.Cms.DAL.Models.ValueFields;

var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING") ??
                       throw new InvalidOperationException("CONNECTION_STRING");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Services
builder.Services.AddScoped<IModelService, ModelService>();

// Repositories
builder.Services.AddScoped<IModelRepository, ModelRepository>();

// Context
builder.Services.AddDbContext<CmsDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Remove in production
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetService<CmsDbContext>();
    
    context?.Database.EnsureDeleted();
    context?.Database.EnsureCreated();
    
    // speaker
    
    var speaker = new Model
    {
        Name = "speaker"
    };

    var brand = new StringKeyField
    {
        Key = "brand",
        Model = speaker
    };
    
    var model = new StringKeyField
    {
        Key = "model",
        Model = speaker
    };  
    
    var wattage = new IntegerKeyField
    {
        Key = "wattage",
        Model = speaker
    };

    var edifier = new Instance
    {
        Model = speaker,
    };

    var brandValue = new StringValueField
    {
        Instance = edifier,
        KeyField = brand,
        Value = "Edifier"
    };
    
    var modelValue = new StringValueField
    {
        Instance = edifier,
        KeyField = model,
        Value = "s351db"
    };
    
    var wattageValue = new IntegerValueField
    {
        Instance = edifier,
        KeyField = wattage,
        Value = 150
    };
    
    context?.Models.Add(speaker);
    context?.Instances.Add(edifier);
    
    context?.StringKeyFields.Add(brand); 
    context?.StringKeyFields.Add(model);
    context?.IntegerKeyFields.Add(wattage);
    
    context?.StringValueFields.Add(brandValue);
    context?.StringValueFields.Add(modelValue);
    context?.IntegerValueFields.Add(wattageValue);

    context?.SaveChanges();
        
    // header

    var header = new Model
    {
        Name = "header"
    };

    var instance = new Instance
    {
        Model = header,
    };

    var greetingField = new StringKeyField
    {
        Key = "greeting",
        Model = header,
    };
    
    var greetingValue = new StringValueField
    {
        Value = "Hello there, it's Steve",
        KeyField = greetingField,
        Instance = instance,
    };
    
    var occupationField = new StringKeyField
    {
        Key = "occupation",
        Model = header,
    };
    
    var occupationValue = new StringValueField
    {
        Value = "Student, Web designer & Software Engineer",
        KeyField = occupationField,
        Instance = instance,
    };
    
    var ageField = new IntegerKeyField()
    {
        Key = "age",
        Model = header,
    };
    
    var ageValue = new IntegerValueField
    {
        Value = 21,
        KeyField = ageField,
        Instance = instance,
    };
    
    var priceField = new DecimalKeyField
    {
        Key = "age",
        Model = header,
    };

    var priceValue = new DecimalValueField
    {
        Value = 10.3M,
        KeyField = priceField,
        Instance = instance
    };

    var randomField = new DoubleKeyField
    {
        Key = "random",
        Model = header,
    };

    var randomValue = new DoubleValueField
    {
        Value = 12.3,
        KeyField = randomField,
        Instance = instance
    };

    var nestedField = new InstanceKeyField()
    {
        Key = "nested",
        Model = header,
    };
    
    var nestedValue = new InstanceValueField()
    {
        Value = [edifier.Id, edifier.Id, edifier.Id],
        KeyField = nestedField,
        Instance = instance
    };
    
    // Header
    
    context?.Models.Add(header);
    context?.Instances.Add(instance);

    context?.StringKeyFields.Add(greetingField);
    context?.StringKeyFields.Add(occupationField);
    context?.IntegerKeyFields.Add(ageField);
    context?.DecimalKeyFields.Add(priceField);
    context?.DoubleKeyFields.Add(randomField);
    context?.InstanceKeyFields.Add(nestedField);
    
    context?.StringValueFields.Add(greetingValue);
    context?.StringValueFields.Add(occupationValue);
    context?.IntegerValueFields.Add(ageValue);
    context?.DecimalValueFields.Add(priceValue);
    context?.DoubleValueFields.Add(randomValue);
    context?.InstanceValueFields.Add(nestedValue);
    
    context?.SaveChanges();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
