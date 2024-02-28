using AutoMapper;
using FMData.Context;
using FMRepository.Abstract;
using FMRepository.Concrete.User;
using FMServices.UserService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cors 
//izin ayarlarý buradan yapýlýyor
builder.Services.AddCors(options => {
	options.AddPolicy("AllowAll", builder => {
		builder.AllowAnyOrigin()
			   .AllowAnyMethod()
			   .AllowAnyHeader();
	});
});
builder.Services.AddDbContext<FmContext>(options => {
	options.UseSqlServer(builder.Configuration.GetConnectionString(name: "DefaultConnectionString"));
});
//Dependency.Injection
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IUserService,UserService>();
//AutoMapperConfig
var mapperConfig = new MapperConfiguration(mc => {
	mc.AddProfile(new FMServices.Mappers.MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
