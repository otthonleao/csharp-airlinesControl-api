using AirlinesControl.Contexts;
using AirlinesControl.Services;

var builder = WebApplication.CreateBuilder(args);

// ADICIONAR SERVIÇOS NO CONTAINER
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(); // Adiciona autenticação e autorização
builder.Services.AddAuthorization(); // Adiciona os serviços de autorização
builder.Services.AddDbContext<AirlinesControlContext>();
builder.Services.AddTransient<AeronaveService>();

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
