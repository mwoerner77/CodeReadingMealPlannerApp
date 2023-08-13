//74: 
//
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//75: 
//
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//76: 
//
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//77: 
//
app.UseHttpsRedirection();

//78: 
//
app.UseAuthorization();

//79: 
//
app.MapControllers();

//80
//: 
//
app.Run();
