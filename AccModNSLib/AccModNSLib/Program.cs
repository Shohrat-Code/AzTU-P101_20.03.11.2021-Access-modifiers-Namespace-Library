using AccModNSLib.Services;
using Models;
using MyMath;
using System;

namespace AccModNSLib
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int[] ages = new int[5];
            //ages.ToList();

            //Category category = new Category();
            //Social social = new Social();

            //SocialService socialService1 = new SocialService();
            //Console.WriteLine(Console.ReadLine());
            //Console.ReadLine();

            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(5, 10));
            //Console.WriteLine(calculator.Power(5, 3));
            //Console.WriteLine(calculator.Add(15.5M, 4.5M));
            //Console.WriteLine(calculator.AreaOfRectangle(5, 10));

            //Social social = new Social();
            //social.Surname = "Agayev";

            //Test test = new Test();
            //Console.WriteLine(test.GetAddress());
            //Console.WriteLine(test.address);


            CarServices carServices = new CarServices();

            Car car1 = new Car()
            {
                Id = 1,
                Brand = "Audi",
                Model = "RS7",
                Year = 2020
            };

            Car car2 = new Car()
            {
                Id = 2,
                Brand = "BMW",
                Model = "X6",
                Year = 2019
            };

            Car car3 = new Car()
            {
                Id = 3,
                Brand = "Mercedes",
                Model = "GL500",
                Year = 2018
            };

            carServices.Create(car1);
            carServices.Create(car2);
            carServices.Create(car3);

            //Car findedCar = carServices.Read(1);
            //if (findedCar!=null)
            //{
            //    Console.WriteLine(findedCar.Brand);
            //}
            //else
            //{
            //    Console.WriteLine("There is no such car!");
            //}
            foreach (Car car in carServices.ReadAll())
            {
                Console.WriteLine($"Brand: {car.Brand}; Model: {car.Model}");
            }
            Console.WriteLine("***********************************************");
            carServices.Delete(3);

            foreach (Car car in carServices.ReadAll())
            {
                Console.WriteLine($"Brand: {car.Brand}; Model: {car.Model}");
            }
        }
    }

    class Test : Calculator
    {
        public string address
        {
            get
            {
                return this.Address;
            }
        }
        public Test()
        {
            this.Address = "Baku";
        }

        public string GetAddress()
        {
            return this.Address;
        }
    }
}
