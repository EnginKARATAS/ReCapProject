using Business.Concrete;
using Dal.Abstract;
using Dal.Concrete;
using Entities;
using System;
using System.Collections.Generic;

namespace Console
{
	class Program
	{
		static void Main(string[] args)
		{
			ICarDal memoryCarDal = new InMemoryCarDal();
			ICarDal sqlCarDal = new SqlCarDal();
			Car car1 = new Car { Description = "hell yea" };

			CarManager carManager = new CarManager(memoryCarDal);
			carManager.GetAll();
			carManager.Add(car1);
			carManager.Delete(car1);

		}

	}
}