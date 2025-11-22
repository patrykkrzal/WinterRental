using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WinterRental.DTO
{
    public class LoginDto
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}