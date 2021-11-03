using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccModNSLib.Services
{
    class CarServices
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

        public Car[] Read()
        {
            return _db.Cars;
        }
    }
}
