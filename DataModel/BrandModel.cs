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

        public bool AddBrand(Brands brand)
        {
           return _BrandManager.AddBrand(brand);
        }

        public bool DeleteBrand(int id)
        {
            return _BrandManager.DeleteBrand(id);
        }

        public IEnumerable<Brands> GetAllBrands()
        {
            return _BrandManager.GetAllBrands();
        }

        public Brands GetBrandInfo(int id)
        {
            return _BrandManager.GetBrandInfo(id);
        }

        public bool UpdateBrand(Brands brand)
        {
            return _BrandManager.UpdateBrand(brand);
        }
    }
}