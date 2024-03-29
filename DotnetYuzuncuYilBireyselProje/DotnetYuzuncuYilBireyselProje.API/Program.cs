﻿using DotnetYuzuncuYilBireyselProje.Core.Repository;
using DotnetYuzuncuYilBireyselProje.Core.Services;
using DotnetYuzuncuYilBireyselProje.Core.UnitOfWorks;
using DotnetYuzuncuYilBireyselProje.Repository;
using DotnetYuzuncuYilBireyselProje.Repository.Repositories;
using DotnetYuzuncuYilBireyselProje.Repository.UnitOfWorks;
using DotnetYuzuncuYilBireyselProje.Service;
using DotnetYuzuncuYilBireyselProje.Service.Mapping;
using DotnetYuzuncuYilBireyselProje.Service.Services;
using DotnetYuzuncuYilBireyselProje.Service.Validations;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddScoped<IStoreService, StoreService>();
builder.Services.AddControllers()
    .AddFluentValidation(x =>
    {
        x.RegisterValidatorsFromAssemblyContaining<ClientDtoValidator>();
        x.RegisterValidatorsFromAssemblyContaining<ClientProfileDtoValidator>();
        x.RegisterValidatorsFromAssemblyContaining<StoreDtoValidator>();
});
//AppDbContext işlemler

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

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
