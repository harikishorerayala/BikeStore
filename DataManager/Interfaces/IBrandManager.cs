using DataTransfers;
using System.Collections.Generic;

namespace DataManager.Interfaces
{
    public interface IBrandManager
    {
        IEnumerable<Brands> GetAllBrands();
    }
}