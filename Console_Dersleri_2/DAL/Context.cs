using Console_Dersleri_2.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri_2.DAL
{
    internal class Context:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Job> Jobs  { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}


/*
 DbFirst: SQL deki tablolar birer sınıfa bu tablolar içinde yer alan sütunlar ise birer property e donusuyor 

CodeFirst: C# daki sınıflar SQL de birer tabloya, sınıflar içindeki proplar ise birer tablo sutununa donusecek.

 S' takısı pluralize , senin sınıfların ve tabloların birbirine karısmasın dıye yalını halını sınıf cogul halını tablo olara tutucam 
JOB>>>CLASS
JOBS>>TABLE
 */