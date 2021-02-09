using Core.DataAccess;
using DataAccess.Concrete.EntitiyFramework;
using Core.Entities;
using Entities.Concrete;
using System;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RcpCarsContext>, IBrandDal
    {
      
    }
}
