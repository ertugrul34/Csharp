using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id=1, FirstName="Engin", LastName="Demiroğ", City="Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Console.WriteLine(customer2.FirstName);

        }
    }

    class Customer
    {
        //Hem parametreli hem de parametresiz ctor yaratıldı. İki tip kullanım için
        public Customer()
        {

        }
        //Constructor içi boş olsa bile default olarak vardır ve çalışır
        public Customer(int id,string firstname,string lastname,string city)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.City = city;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}
