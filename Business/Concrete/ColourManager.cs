using Business.Abstract;
using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;

        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }

        public List<Colour> GetAll()
        {
            return _colourDal.GetAll();
        }

        public List<Colour> GetById(int colourId)
        {
            return _colourDal.GetAll(c=>c.ColourId == colourId);
        }

        public void Add(Colour colour)
        {
            _colourDal.Add(colour);
        }

        public void Delete(int colourId)
        {
            Colour deletedColour = _colourDal.GetAll(c => c.ColourId == colourId).SingleOrDefault();
            _colourDal.Delete(deletedColour);

        }

        public void Update(int colourId)
        {
            Colour updatedColour = _colourDal.GetAll(c => c.ColourId == colourId).SingleOrDefault();
            updatedColour.ColourName = "Black";
            _colourDal.Update(updatedColour);
        }
    }
}
