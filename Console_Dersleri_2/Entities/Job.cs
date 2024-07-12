using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri_2.Entities
{
    internal class Job
    {
        [Key]
        public int JobID { get; set; }
        public String JonName { get; set; }
}
}
