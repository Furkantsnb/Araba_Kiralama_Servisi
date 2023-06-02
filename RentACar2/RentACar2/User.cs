using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RentACar2
{
    internal class User
    {
        public string UserName { get; set; }
        private List<Car> RentalCars;

        public User(string userName)
        {
            UserName = userName;
            RentalCars = new List<Car>();
        }
        
        

        public void RentACar(Car car, int day)
        {
            if (car.Status)
            {
                car.Status = false;
                Console.WriteLine("=================================================================");
                Console.WriteLine($"Araba plakası: {car.Plate} -\t Kiralayan: {UserName}");
                decimal rentMoney = (decimal)(car.RentMoney * day);
                Console.WriteLine($"Kiralanan araç: {car.Brand} {car.Model}");
                Console.WriteLine($"Kira süresi: {day} gün");
                Console.WriteLine($"Toplam kira ücreti: {rentMoney} TL");
                Console.WriteLine("=================================================================");
                RentalCars.Add(car);
            }
            else
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine($"Araba plakası: {car.Plate} - Kiralama işlemi yapılamaz. Araç muayenede.");
                Console.WriteLine("========================================================================");
            }
   
            
        }

        public void ListRentalCars()
        {
            
            if (RentalCars == null || RentalCars.Count == 0)
            {
                Console.WriteLine("Kiralanan araç bulunmamaktadır.");
            }
            else
            {

                foreach (Car arac in RentalCars)
                {
                    Console.WriteLine($"Kullanıcı: {UserName} -\t Kiralanan Araçlar:" + arac.Plate);
                   
                }
            }
        }



    }
}
