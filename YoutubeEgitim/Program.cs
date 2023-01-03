using System;

namespace YoutubeEgitim
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager(new Customer(),new MilitaryCreditManager());
            customerManager.giveCredit();


            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 100;
            Console.WriteLine(number1);

            int[] sayilar1 = new[] { 1, 2, 3 };
            int[] sayilar2 = new[] { 10, 20, 30 };

            sayilar1 = sayilar2;

            sayilar2[0] = 1000;

            Console.WriteLine(sayilar1[0]);

            string x = "object oriented programming";
            Console.WriteLine(x.ToUpper());

        }
        class CreditManager
        {
            public void Calculete()
            {
                Console.WriteLine("Hesaplandı");
            }
            public void Save()
            {
                Console.WriteLine("Kredi verildi");
            }

        }
                 class TeacherCreditManager : BaseCreditManager , ICreditManager 
                  {   
                    public override void Calculete()
                    {
                    Console.WriteLine("Öğretmen kredisi hesaplandı");
                    }

                    public override void Save()
                    {
                    base.Save();
                    }


        }

            class MilitaryCreditManager : BaseCreditManager , ICreditManager
            {
                public override void Calculete()
                {
                    Console.WriteLine("Asker kredisi hesaplandı");
                }

            }

            interface ICreditManager
            {
                void Calculete();
                void Save();
            }
        abstract class BaseCreditManager : ICreditManager
        {
            public abstract void Calculete();
            

            public virtual void Save()
            {
                Console.WriteLine("Kaydedildi");
            }
        }

        class Customer
            {
                public Customer()
                {
                    Console.WriteLine("Musteri nesnesi başlatıldı");
                }
                public int Id { get; set; }
                public string City { get; set; }
            }
            class CustomerManager
            {
                private Customer _customer;

                private ICreditManager _creditManager;
                public CustomerManager(Customer customer, ICreditManager creditManager)
                {
                    _customer = customer;
                    _creditManager = creditManager;
                }

                public void Save()
                {
                    Console.WriteLine("Müşteri Kaydedildi " + _customer.Id);
                }

                public void Silindi()
                {
                    Console.WriteLine("Müşteri silindi " + _customer.Id);
                }
                public void giveCredit()
                {
                    _creditManager.Calculete();
                    Console.WriteLine("Kredi verildi");
                }
            }

            class Company : Customer
            {

                public string CompanyName { get; set; }
                public string TextNumber { get; set; }
            }
            class Person : Customer
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public string NationalIdentity { get; set; }

            }
        }
    }
