using DataManager.Interfaces;
using DataModel.Interfaces;
using DataTransfers;
using System.Collections.Generic;

namespace DataModel
{
    public class BrandModel : IBrandModel
    {
        private IBrandManager _BrandManager;

        public BrandModel(IBrandManager mgr)
        {
            this._BrandManager = mgr;
        }

        public IEnumerable<Brands> GetAllBrands()
        {
            return _BrandManager.GetAllBrands();
        }
    }
}