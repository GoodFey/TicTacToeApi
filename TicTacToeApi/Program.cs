using Microsoft.EntityFrameworkCore;
using TicTacToeApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UserDb>(opt => opt.UseInMemoryDatabase("UserList"));

var app = builder.Build();

app.MapGet("/", () => "Welcome to Tic Tac Toe Game!");

app.MapPost("/UserTurn", async (User user, UserDb db) =>
{
    db.Users.Add(user);
    await db.SaveChangesAsync();

    return Results.Created($"/Users/{user.Id}", user);
});

app.MapGet("/showAllUsersTurns", async (UserDb db) =>
    await db.Users.ToListAsync());

app.Run();
