var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("AllowReactApp");

app.MapPost("/login", (LoginRequest request) =>
{
    if (request.Email == "usuario@teste.com" && request.Password == "123456")
    {
        return Results.Ok(new { message = "Login bem-sucedido!" });
    }
    else
    {
        return Results.Json(new { message = "Email ou senha inválidos." }, statusCode: 401);
    }
});

app.Run();

public record LoginRequest(string Email, string Password);