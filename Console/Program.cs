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

			CarManager carManager = new CarManager(new InMemoryCarDal());
			carManager.GetAll();	
			

		

          

		}

	}
}