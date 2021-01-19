using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo_
{
   public  class CustomerManagerForBank
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"Added customer: {customer.Id} {customer.Name} {customer.Lastname}");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"Deleted customer :{customer.Id} {customer.Name} {customer.Lastname}");
        }
        public void List(Customer[] customers)
        {
            Console.WriteLine("Customer Listed");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Lastname);
            }
        }


        public void Add2(المشتري مشتري)
        {
            Console.WriteLine($"انضاف الي المشتري :{مشتري.رقمالمشتري}{مشتري.اسم} {مشتري.لقب}");
        }

        public void Delete2(المشتري مشتري)
        {
            Console.WriteLine($"حفظ المشتري  :{مشتري.رقمالمشتري} {مشتري.اسم} {مشتري.لقب}");
        }
        //list
        public void List2(المشتري[] مشتري)
        {
            Console.WriteLine("المشترون قائمون");
            foreach (المشتري مشترينا in مشتري)
            {
                Console.WriteLine(مشترينا.اسم + " " + مشترينا.لقب);
            }
        }
}
