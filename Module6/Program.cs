using System.Xml.Linq;

namespace Module6
{
    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
        }

        static Department GetCurrentDepartment()
        { 
            Department department = new Department();
            City city = new City { Name= "Санкт-Петербург" };
            Company company = new Company { Type = "Банк" , Name = "City" };
            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
            return department;
        }
    }
}