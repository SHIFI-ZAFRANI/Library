using library;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Data.Repoistories;
using Library.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IBookServices, BookService>();
builder.Services.AddScoped<IUserServices, UserService>();
builder.Services.AddScoped<ICategoryServices, CategoryService>();


builder.Services.AddSingleton<DataContext>();
//var policy = "policy";
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: policy, policy =>
//    {
//        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
//    });
//});



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

//app.UseCors(policy);


app.Run();





