using DataTransfers;
using System.Collections.Generic;

namespace DataModel.Interfaces
{
    public interface IBrandModel
    {
        IEnumerable<Brands> GetAllBrands();
    }
}