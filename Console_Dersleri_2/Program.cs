using Console_Dersleri_2.DAL;
using Console_Dersleri_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person
            //Job
            //Data Acces layer -->> DAL --> SQL connection 
            //Context>-->> Veri tabanı bağlantı adresi ve VT bağlantı yapılandırması

            //code first

            Context c =new Context();
            var values = c.Customers.ToList();

            void listele()
            {
                foreach (var item in values)
                {
                    Console.WriteLine(item.CustomerName);
                }
            }
            //Ekleme
            Customer customer = new Customer();
            customer.CustomerName = "Eylül Yüce";
            customer.CustomerCity = "Honkong";
            c.Customers.Add(customer);
            c.SaveChanges();
            listele();


            //silme

            var values2 = c.Customers.Where(x => x.CustomerID == 3).FirstOrDefault();
            c.Customers.Remove(values2);
            c.SaveChanges();
            Console.WriteLine("Silme işlemi tamamlandı");
            listele();


            //Güncelleme

            var values3 = c.Customers.Where(x => x.CustomerID == 2).FirstOrDefault();
            values3.CustomerName = "Ali Cengiz";
            values3.CustomerCity = "Kastamonu";
            c.SaveChanges();

            Console.ReadLine();
        }
    }
}
