using System;

namespace ClassMethodDemo_
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Gülnisa";
            customer1.Lastname = "Aslan";
            customer1.Money = 5000;
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Haşim";
            customer2.Lastname = "Aslan";
            customer2.Money = 1000;
            //Arapça ile yazılmış kodlar
            المشتري مشترينا1 = new المشتري();
            مشترينا1.رقمالمشتري = 3;
            مشترينا1.اسم = "زيد";
            مشترينا1.لقب = "برق";
            مشترينا1.فلص = 10000;


            المشتري مشترينا2 = new المشتري();
            مشترينا2.رقمالمشتري = 4
                ;
            مشترينا2.اسم = "خالد";
            مشترينا2.لقب = "صاوان";
            مشترينا2.فلص = 110000;

            المشتري[] مشترينا = new المشتري[] { مشترينا1, مشترينا2 };
            foreach (المشتري مشتري in مشترينا)
            {
                Console.WriteLine(مشتري.رقمالمشتري);
                Console.WriteLine(مشتري.اسم);
                Console.WriteLine(مشتري.لقب);
                Console.WriteLine(مشتري.فلص);
                Console.WriteLine("--------------------------------");
            }




            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Lastname);
                Console.WriteLine(customer.Money);
                Console.WriteLine("--------------------------------");


            }


            //add
            CustomerManagerForBank customerManagerForBank = new CustomerManagerForBank();
            customerManagerForBank.Add(customer1);
            Console.WriteLine("______________________");
            customerManagerForBank.Add(customer2);
            Console.WriteLine("______________________");
            customerManagerForBank.Add2(مشترينا1);
            Console.WriteLine("______________________");
            customerManagerForBank.Add2(مشترينا2);

            //delete
            customerManagerForBank.Delete(customer1);
            Console.WriteLine("______________________");
            customerManagerForBank.Delete(customer2);
            Console.WriteLine("______________________");
            customerManagerForBank.Delete2(مشترينا1);
            Console.WriteLine("______________________");
            customerManagerForBank.Delete2(مشترينا2);
            //list
            customerManagerForBank.List(customers);
            Console.WriteLine("______________________");

            customerManagerForBank.List2(مشترينا);

        }
    }
}
