
namespace RentACar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarRentalSystem RentalSystem = new CarRentalSystem();
            List<User> UserList = new List<User>();

            // Örnek araçlar oluşturma ve sisteme ekleme
            Car car1 = new Cars("34 ABC 01", "Ford", "Focus", 2018, 50000, "Kırmızı", 100, true);
            Car car2 = new Minibus("34 DEF 02", "Mercedes", "Sprinter", 2020, 100000, "Beyaz", 200, false);
            Car car3 = new Truc("34 GHI 03", "Volvo", "FH16", 2019, 200000, "Mavi", 300, true);

            RentalSystem.AddCar(car1);
            RentalSystem.AddCar(car2);
            RentalSystem.AddCar(car3);





            Console.WriteLine("-----------------------------------");
            Console.WriteLine("ARAÇ KİRALAMA SİSTEMİNE HOŞGELDİNİZ");
            Console.WriteLine("-----------------------------------");

            while (true)
            {
                Console.WriteLine("*********************************");
                Console.WriteLine("1- Araçları Listele");
                Console.WriteLine("2- Araç Kirala");
                Console.WriteLine("3- Kiralanan Araçları Listele");
                Console.WriteLine("4- Araç Ekle");
                Console.WriteLine("5- Çıkış");
                Console.WriteLine("*********************************");
                Console.Write("Seçiminizi yapın: ");

                int selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        RentalSystem.ListCars();
                        break;
                    case 2:
                        Console.Write("Kiralayan kişinin adı: ");
                        string UserName = Console.ReadLine().ToUpper().Trim();
                        User user = new User(UserName);
                        UserList.Add(user);

                        Console.Write("Kiralayacağınız aracın plakasını girin: ");
                        string plate = Console.ReadLine().ToUpper().Trim();

                        Console.Write("Kiralama süresini gün olarak girin: ");
                        int day = int.Parse(Console.ReadLine().Trim());

                        Car car = RentalSystem.FindTheCar(plate);
                        
                        if (car != null)
                        {
                            decimal rentMoney = RentalSystem.CalculateRentalFee(car, day);
                            user.RentACar(car, day);
                        }
                        else
                        {
                            Console.WriteLine("Aracı bulunamadı.");
                        }
                        break;
                    case 3:
                       foreach(User users in UserList)
                        {
                            users.ListRentalCars();
                        }
                        break;
                    case 4:
                        Console.Write("Araç plakasını girin: ");
                        string Plate= Console.ReadLine().ToUpper().Trim();
                        Console.Write("Araç markasını girin: ");
                        string brand = Console.ReadLine().ToUpper().Trim();
                        Console.Write("Araç modelini girin: ");
                        string model = Console.ReadLine().ToUpper().Trim();
                        Console.Write("Araç üretim yılını girin(Örnek: 2013): ");
                        int yearOfProduction = int.Parse(Console.ReadLine().Trim());
                        Console.Write("Araç km'sini girin(örnek : 123) : ");
                        int km = int.Parse(Console.ReadLine().Trim());
                        Console.Write("Araç rengini girin : ");
                        string colour = Console.ReadLine().ToUpper().Trim();
                        Console.Write("Araç türünü girin (1- Otomobil, 2- Minibüs, 3- Kamyon): ");
                        String tür = Console.ReadLine().ToUpper().Trim();
                        Console.Write("Araç kira ücretini girin (Örnek: 500): ");
                        double RentMoney = double.Parse(Console.ReadLine().Trim());
                        Console.Write("Araç durumunu girin (true- Muayenede, false- Hizmet Dışı): ");
                        bool status = bool.Parse(Console.ReadLine().ToLower().Trim());
                        Console.WriteLine("===========================================================================================");

                        TypeOfCar newType;
                        switch (tür)
                        {
                            case "1":
                                newType = TypeOfCar.Car;
                                break;
                            case "2":
                                newType = TypeOfCar.Minibus;
                                break;
                            case "3":
                                newType = TypeOfCar.Truc;
                                break;
                            default:
                                Console.WriteLine("Geçersiz tür seçimi!");
                                continue;
                        }
                        
                        Car newCar = null;
                        switch (newType)
                        {
                            case TypeOfCar.Car:
                                newCar = new Cars(Plate, brand, model,yearOfProduction, km, colour, RentMoney,  status);
                                break;
                            case TypeOfCar.Minibus:
                                newCar = new Minibus(Plate, brand, model, yearOfProduction, km, colour, RentMoney, status);
                                break;
                            case TypeOfCar.Truc:
                                newCar = new Truc(Plate, brand, model, yearOfProduction, km, colour, RentMoney, status);
                                break;
                        }

                        if (newCar != null)
                        {
                            RentalSystem.AddCar(newCar);
                            Console.WriteLine("Araç başarıyla eklendi.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }

               
              


            }
        }
    }
}