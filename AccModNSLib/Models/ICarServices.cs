using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ICarServices
    {
        Car[] ReadAll();
        Car Read(int id);
        bool Create(Car car);
        bool Update(int id, Car car);
        bool Delete(int id);
    }
}
