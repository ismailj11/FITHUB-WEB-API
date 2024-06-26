using FITHUB_WEB_API.Extensions;
using FITHUB_WEB_API.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.addDb(builder.Configuration);
builder.Services.AddAutoMapperConfig();
builder.Services.AddRepositories();
builder.Services.AddServiceExtension();

builder.Services.AddControllers(options =>
{
    options.Filters.Add(new GlobalExceptionFilter());
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();