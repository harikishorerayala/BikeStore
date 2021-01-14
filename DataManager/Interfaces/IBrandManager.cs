using DataTransfers;
using System.Collections.Generic;

namespace DataManager.Interfaces
{
    public interface IBrandManager
    {
        IEnumerable<Brands> GetAllBrands();
        Brands GetBrandInfo(int id);
        bool AddBrand(Brands brand);
        bool UpdateBrand(Brands brand);
    }
}