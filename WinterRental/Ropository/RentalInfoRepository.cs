using WinterRental.Data;
using WinterRental.Interfaces;
using WinterRental.Models;

namespace WinterRental.Ropository
{
    public class RentalInfoRepository : IRentalInfoRepository
    {
        private readonly DataContext _context;


        public  RentalInfoRepository(DataContext context)

        { 
            _context = context;
        } 
        public ICollection<RentalInfo> GetRentalInfos()
        {
            return _context.RentalInfo.OrderBy(r => r.Id ).ToList();
        }
    }
}
