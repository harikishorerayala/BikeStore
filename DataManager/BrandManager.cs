using DataManager.Interfaces;
using DataTransfers;
using System.Collections.Generic;
using System.Linq;

namespace DataManager
{
    public class BrandManager : IBrandManager
    {
        public bool AddBrand(Brands brand)
        {
            using (BikeStoreEntities entities = new BikeStoreEntities())
            {
                brand obj = new brand
                {
                    brand_id = brand.Brand_Id,
                    brand_name = brand.Brand_Name
                };
                entities.brands.Add(obj);
                var affected = entities.SaveChanges();

                if (affected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeleteBrand(int id)
        {
            using (BikeStoreEntities entities = new BikeStoreEntities())
            {
                var result = entities.brands.FirstOrDefault(a => a.brand_id == id);
                entities.brands.Remove(result);
                var affected = entities.SaveChanges();
                if (affected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public IEnumerable<Brands> GetAllBrands()
        {
            using (BikeStoreEntities entities = new BikeStoreEntities())
            {
                return entities.brands.ToList().Select(a => new Brands() { Brand_Id = a.brand_id, Brand_Name = a.brand_name }).ToList();
            }
        }

        public Brands GetBrandInfo(int id)
        {
            using (BikeStoreEntities entities = new BikeStoreEntities())
            {
                var result = entities.brands.FirstOrDefault(a => a.brand_id == id);
                Brands obj = new Brands
                {
                    Brand_Name = result.brand_name,
                    Brand_Id = result.brand_id
                };
                return obj;
            }
        }

        public bool UpdateBrand(Brands brand)
        {
            using (BikeStoreEntities entities = new BikeStoreEntities())
            {
                var result = entities.brands.FirstOrDefault(a => a.brand_id == brand.Brand_Id);

                result.brand_name = brand.Brand_Name;

                var affected = entities.SaveChanges();

                if (affected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}