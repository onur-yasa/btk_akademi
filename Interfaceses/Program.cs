using System;

namespace Interfaceses
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            // Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
             };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManeger personManeger = new PersonManeger();
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Nasuh Onur",     //--> Yazım Tekniği.
            //    LastName = "Yaşa",
            //    Address = "Manisa"
            //};
            //personManeger.Add(customer);

            personManeger.Add(new Customer { Id = 1, FirstName = "Nasuh Onur", LastName = "Yaşa", Address = "Manisa" });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Onur",
                LastName = "Yaşa",
                Departmant = "Elazığ"
            };
            personManeger.Add(student);
        }
    }
    interface IPerson //Soyut Nesne-Tek başına hiç bir anlam ifade etmez.
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson  //Somut Nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManeger
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
