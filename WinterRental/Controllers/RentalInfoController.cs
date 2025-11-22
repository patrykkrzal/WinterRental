using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WinterRental.Interfaces;
using WinterRental.Models;
using WinterRental.Ropository;

namespace WinterRental.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RentalInfoController : Controller
    {
        private readonly IRentalInfoRepository _RentalInfoRepository;

        public RentalInfoController(IRentalInfoRepository  RentalInfoRepository)
        {
            _RentalInfoRepository = RentalInfoRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type=typeof(IEnumerable<RentalInfo>))] 
        public IActionResult GetRentalInfos()
        {
            var rentalInfo = _RentalInfoRepository.GetRentalInfos();
            if (!ModelState.IsValid)
                return BadRequest(ModelState); 
            return Ok(rentalInfo);
        }

        [Authorize]
        [HttpGet("me")]
        public IActionResult Me()
        {
            return Ok("Jesteś zalogowany!");
        }
        [Authorize(Roles = "admin")]
        [HttpGet("admin")]
        public IActionResult Admin()
        {
            return Ok("Witaj adminie!");
        }

    }
}
