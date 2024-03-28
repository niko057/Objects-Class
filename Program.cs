
using Microsoft.VisualBasic.FileIO;
using System.Drawing;
using System.Xml.Linq;

namespace Objects_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Nicat","Namazov",27);

            //Car car = new Car("BMW","M5",2020,"Benzin","Qara");

            //car.PrintInfo();

            //Car1 car1 = new Car1("Kia","Optima",2016,210,5);
            //Motorcycle motorcycle =new Motorcycle("Sym", "Xpro", 2020, 75, 2);

            User user = new User
            {
                Name = "username",
                Password = "password123"
            };

            
            Console.WriteLine(user.IsPasswordValid()); 

            
            

        }
    }
    public class Person
    {
        public string Name;
        public string Surname;
        public byte Age;
        public bool isAdult;

        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;

            if (age > 18)
            {
               isAdult= true;
            }
            else
            {
               isAdult= false;
            }

            Console.WriteLine(isAdult);

        }
    }

    public class Car
    {
        public string Brend;
        public string Model;
        public int Year;
        public string FuelType;
        public string Color;

        public Car(string brend, string model, int year, string fuelType, string color)
        {
            Brend = brend;
            Model = model;
            Year = year;
            FuelType = fuelType;
            Color = color;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Brend>{Brend}\nModel>{Model}\nIl>{Year}\nYanacaq>{FuelType}\nReng>{Color}");
         }
    }

    public class Car1
    {
        public string Brend;
        public string Model;
        public int Year;
        public int MaxSpeed;
        public byte NumSeats;

        public Car1(string brend, string model, int year, int maxspeed,byte numseats)
        {
            Brend = brend;
            Model = model;
            Year = year;
            MaxSpeed= maxspeed;
            NumSeats= numseats;

            if (maxspeed > 110)
            {
                Console.WriteLine($"{Brend}>Suret oldurur");
            }
            else
            {
                Console.WriteLine($"{Brend}>Bele davam edin");
            }
        }
    }
    public class Motorcycle
    {
        public string Brend;
        public string Model;
        public int Year;
        public int MaxSpeed;
        public byte HasSidecar;

        public Motorcycle(string brend, string model, int year, int maxspeed,byte hassidecar)
        {
            Brend = brend;
            Model = model;
            Year = year;
            MaxSpeed= maxspeed;
            HasSidecar= hassidecar;

            if (maxspeed > 110)
            {
                Console.WriteLine($"{Brend}>Suret oldurur");
            }
            else
            {
                Console.WriteLine($"{Brend}>Bele davam edin");
            }

        }
    }


    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }


       

        public bool IsPasswordValid()
        {

            if (Password.Length < 6 || !Password.Any(char.IsDigit) || Password.Contains(Name))
            {
                return false;
            }

            return true;
        }

    }
}