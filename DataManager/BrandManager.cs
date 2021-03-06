﻿using DataManager.Interfaces;
using DataTransfers;
using System.Collections.Generic;
using System.Linq;

namespace DataManager
{
    public class BrandManager : IBrandManager
    {
        public IEnumerable<Brands> GetAllBrands()
        {
            using (BikeStoreEntities entities = new BikeStoreEntities())
            {
                ;
                return entities.brands.ToList().Select(a => new Brands() { Brand_Id = a.brand_id, Brand_Name = a.brand_name }).ToList();
            }
        }
    }
}