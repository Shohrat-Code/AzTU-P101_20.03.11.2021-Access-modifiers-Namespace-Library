using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AccModNSLib.Services
{
    class CarServices : ICarServices
    {
        private DB _db;
        public CarServices()
        {
            this._db = new DB();
        }
        public bool Create(Car car)
        {
            Array.Resize(ref _db.Cars, _db.Cars.Length + 1);
            _db.Cars[_db.Cars.Length - 1] = car;

            return true;
        }
        public bool Delete(int id)
        {
            _db.Cars = Array.FindAll(_db.Cars, car => car.Id != id);
            return true;
        }
        public Car Read(int id)
        {
            //Car findedCar = new Car();
            //foreach (var item in _db.Cars)
            //{
            //    if (item.Id == id)
            //    {
            //        findedCar = item;
            //        break;
            //    }
            //}
            return Array.Find(_db.Cars, car => car.Id == id);
        }
        public Car[] ReadAll()
        {
            return _db.Cars;
        }
        public bool Update(int id, Car car)
        {
            throw new NotImplementedException();
        }
    }
}
