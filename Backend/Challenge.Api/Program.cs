using Challenge.Domain.Services;
using Challenge.Infrastructure;
using Challenge.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IPokeServices, PokeServices>();
builder.Services.AddTransient<IInteractWithPokemonService, InteractWithPokemonServices>();
builder.Services.AddScoped<PokeEndpoints>();

builder.Services.AddHttpClient();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(
    b => b.AddPolicy(
        name: "default",
        policy => {
            policy
                .WithOrigins("http://localhost:4200")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .SetIsOriginAllowedToAllowWildcardSubdomains();
            }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("default");

app.UseAuthorization();

app.MapControllers();

app.Run();
