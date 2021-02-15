using System;

namespace ConstructorsExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer {Id=1,FirstName="Oğuzhan",LastName="Mavi",City="İstanbul" };




            Customer customer2 = new Customer(2, "Derin", "Demiroğ","Ankara");
        }



     static void Method(int id, string firstname,string lastname,string city)
        {

        }
    }


 


    class Customer
    {

        public Customer()
        {

        }


        // default Constructor 
        public Customer(int id,string firstname,string lastname , string city)
        {
            Console.WriteLine("Yapıcı Blog Çalıştırıldı");
        }


        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string City { get; set; }

    }
}
