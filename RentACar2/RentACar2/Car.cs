using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum TypeOfCar
{
    Car,
    Minibus,
    Truc
}

namespace RentACar2
{
    
       abstract class Car
       {
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public int Km { get; set; }
        public string Colour { get; set; }
        public string Type { get; set; }
        public double RentMoney { get; set; }
        public bool Status { get; set; }

      
       
        public Car(string plate, string brand, string model, int yearOfProduction, int km, string colour, string type, double rentMoney, bool status)
        {
            Plate = plate;
            Brand = brand;
            Model = model;
            YearOfProduction = yearOfProduction;
            Km = km;
            Colour = colour;
            Type = type;
            RentMoney = rentMoney;
            Status = status;
        }

    }

    // Araç sınıfı
    class Cars: Car
    {


        public Cars(string plate, string brand, string model, int yearProduction, int km, string colour, double rentMoney, bool status)
            : base(plate, brand, model, yearProduction, km, colour, "Car", rentMoney, status)
        {

        }


    }

    // Minübüs Sınıfı
    class Minibus : Car
    {
        public Minibus(string plate, string brand, string model, int yearProduction, int km, string colour, double rentMoney, bool status)
           : base(plate, brand, model, yearProduction, km, colour, "Minibus", rentMoney, status)
        {

        }


    }

    // Kamyon sınıfı
    class Truc : Car
    {
        public Truc(string plate, string brand, string model, int yearProduction, int km, string colour, double rentMoney, bool status)
            : base(plate, brand, model, yearProduction, km, colour, "Truc", rentMoney, status)
        {

        }



    }
    
}
