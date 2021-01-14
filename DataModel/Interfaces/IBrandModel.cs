using DataTransfers;
using System.Collections.Generic;

namespace DataModel.Interfaces
{
    public interface IBrandModel
    {
        IEnumerable<Brands> GetAllBrands();

        Brands GetBrandInfo(int id);

        bool AddBrand(Brands brand);

        bool UpdateBrand(Brands brand);

        bool DeleteBrand(int id);
    }
}