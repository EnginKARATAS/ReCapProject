using Business.Abstract;
using Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarDal
    {
        ICarDal _IcarDal;
        public CarManager(ICarDal carDal)
        {
            _IcarDal = carDal;
        }
        public bool Add(Entities.Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entities.Car car)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Car> GetAll()
        {
            return _IcarDal.GetAll();
        }

        public Entities.Car GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.Car car)
        {
            throw new NotImplementedException();
        }
    }
}
