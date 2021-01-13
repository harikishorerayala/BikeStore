using DataManager;
using DataModel.Interfaces;
using DataTransfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class BrandModel : IBrandModel
    {
        public IEnumerable<Brands> GetAllBrands()
        {

            BrandManager obj = new BrandManager();
            return obj.GetAllBrands();
        }
    }
}
