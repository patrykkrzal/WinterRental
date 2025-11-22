using WinterRental.Models;

namespace WinterRental.Interfaces
{
    public interface IRentalInfoRepository
    {
        ICollection<RentalInfo> GetRentalInfos();
    }
}
