using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfColourDal : EfEntityRepositoryBase<Colour, RcpCarsContext>, IColourDal
    {
        
    }
}
