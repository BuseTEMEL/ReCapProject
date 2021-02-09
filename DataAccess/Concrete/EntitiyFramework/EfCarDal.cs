using Core.DataAccess.EntityFramework;
using Core.DataAccess;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using System.Collections.Generic;
using Entities.Dto;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RcpCarsContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RcpCarsContext context = new RcpCarsContext())
            {
                var result = from a in context.Cars
                             join b in context.Brands
                             on a.BrandId equals b.BrandId
                             join c in context.Colours
                             on a.ColourId equals c.ColourId

                             select new CarDetailDto()
                             {
                                 CarName = a.CarName,
                                 BrandName = b.BrandName,
                                 ColourName = c.ColourName,
                                 ModelYear = a.ModelYear,
                                 DailyPrice = a.DailyPrice,
                                 Description = a.Description
                             };




                return result.ToList();
            }


            
        }
    }
}
