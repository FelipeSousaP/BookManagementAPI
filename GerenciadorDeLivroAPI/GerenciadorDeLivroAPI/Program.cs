var builder = WebApplication.CreateBuilder(args);

# region Etapa 2 - Serviçoes
builder.Services.AddControllers();// intocavel
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
# endregion

#region Etapa 3 - Requisições
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
#endregion