using AirlinesControl.Contexts;
using AirlinesControl.Middlewares;
using AirlinesControl.Services;
using AirlinesControl.Validators.Aeronave;
using AirlinesControl.Validators.Piloto;

var builder = WebApplication.CreateBuilder(args);

// ADICIONAR SERVIÇOS NO CONTAINER
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(); // Adiciona autenticação e autorização
builder.Services.AddAuthorization(); // Adiciona os serviços de autorização
builder.Services.AddDbContext<AirlinesControlContext>();
builder.Services.AddTransient<AeronaveService>();
builder.Services.AddTransient<PilotoService>();
builder.Services.AddTransient<AdicionarAeronaveValidator>();
builder.Services.AddTransient<AtualizarAeronaveValidator>();
builder.Services.AddTransient<ExcluirAeronaveValidator>();
builder.Services.AddTransient<AdicionarPilotoValidator>();
builder.Services.AddTransient<AtualizarPilotoValidator>();
builder.Services.AddTransient<ExcluirPilotoValidator>();

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

app.UseMiddleware<ValidationExceptionHandlerMiddleware>();

app.Run();
