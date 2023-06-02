using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar2
{
    internal class CarRentalSystem
    {

        private List<Car> cars;
        public CarRentalSystem()   
        {
            cars = new List<Car>();
        }


        public void AddCar(Car car) 
            {
                cars.Add(car);
            }
            public void ListCars()
            {
                Console.WriteLine("ARAÇ LİSTESİ");

                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("PLAKA\t               MARKA\t       MODEL\t       üRETİM YILI     KİLOMETRE       RENK\t       ARAC TÜRÜ       KİRA ÜCRETİ     MUAYENE DURUMU");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (var car in cars)
                {
                    Console.WriteLine(car.Plate + "\t       " + car.Brand + "\t       " + car.Model + "\t       " + car.YearOfProduction + "\t       " + car.Km + "\t       " + car.Colour + "\t       " + car.Type + "\t       " + car.RentMoney + "\t       " + (car.Status ? "Hizmete Hazır" : "Hizmet Dışı"));

                }
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
            }


            public Car FindTheCar(string plate)
            {
                foreach (var car in cars)
                {
                    if (car.Plate == plate)
                    {
                        return car;
                    }
                }
                return null;
            }


            public decimal CalculateRentalFee(Car araç, int day)
            {
                decimal rentMoney = (decimal)(araç.RentMoney * day);
                return rentMoney;
            }
        }
    }
