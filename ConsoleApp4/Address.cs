using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Address
    {
        int index;
        string country;
        string city;
        string street;
        int house;
        int apartament;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }
        public int Apartament
        {
            get { return apartament; }
            set { apartament = value; }
        }

        public Address()
        {
            
        }

        public Address InputAddress()
        {
            Console.WriteLine("Введіть індекс");
            this.Index = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть країну");
            this.Country = Console.ReadLine();
            Console.WriteLine("Введіть місто");
            this.City = Console.ReadLine();
            Console.WriteLine("Введіть вулицю");
            this.Street = Console.ReadLine();
            Console.WriteLine("Введіть номер будинку");
            this.House = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть номер квартири");
            this.Apartament = int.Parse(Console.ReadLine());
            return this;
        }

        public void PrintAddress()
        {
            Console.WriteLine($"Ваша адреса {this.Index}, країна {this.Country}, місто {this.City}, вул.{this.Street},{this.House}, кв.{this.Apartament}");
        }
    }
}
