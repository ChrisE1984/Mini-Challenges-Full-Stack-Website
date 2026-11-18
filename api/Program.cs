using api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IHelloServices, HelloServices>();
builder.Services.AddScoped<IAddTwoServices,AddTwoServices>();
builder.Services.AddScoped<IGreaterThanServices, GreaterThanServices>();
builder.Services.AddScoped<IMadLibsServices, MadLibsServices>();
builder.Services.AddScoped<IMagicServices, MagicServices>();
builder.Services.AddScoped<IRestaurantServices, RestaurantServices>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy=>{
        // here we are going to let our app know which
        // origins and requests to allow
        policy.AllowAnyOrigin()
        //allows any requests header like Content-Type
        .AllowAnyHeader()
        // allows and HTTP Method: GET, POST, PUT, DELETE
        .AllowAnyMethod();
});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("Frontend");

app.MapControllers();

app.Run();
