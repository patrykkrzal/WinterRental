using BCrypt.Net;
using Microsoft.AspNetCore.Mvc;
using System;
using WinterRental.Data;
using WinterRental.DTO;
using WinterRental.Models;
using WinterRental.Services;

namespace WinterRental.Controllers
[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly DataContext _context;
    private readonly JwtService _jwtService;

    public AuthController(DataContext context, JwtService jwtService)
    {
        _context = context;
        _jwtService = jwtService;
    }

    // ------------------ REJESTRACJA ------------------
    [HttpPost("register")]
    public IActionResult Register(RegisterUserDto dto)
    {
        if (_context.Users.Any(u => u.Login == dto.Login))
            return BadRequest("Login jest już zajęty");

        var user = new User
        {
            First_name = dto.FirstName,
            Last_name = dto.LastName,
            Login = dto.Login,
            Email = dto.Email,
            Phone_number = dto.PhoneNumber,
            Address = dto.Address,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
            Role = "user"
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        return Ok("Utworzono użytkownika");
    }

    // ------------------ LOGOWANIE ------------------
    [HttpPost("login")]
    public IActionResult Login(LoginDto dto)
    {
        var user = _context.Users.FirstOrDefault(x => x.Login == dto.Login);

        if (user == null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
            return Unauthorized("Niepoprawny login lub hasło");

        var token = _jwtService.GenerateJwt(user);

        return Ok(new { token });
    }
}
}