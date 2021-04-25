using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Organizations
{
    public class Employee
    {
        public Branch WorkingPlace { get; set; }
        public string Job { get; set; }
        public int Id { get; set; }
        public string FullName { get; set; }

        public override string ToString()
        {
            return string.Format("Полное имя: {0}\nДолжность: {1}\nID: {2}\n", 
                FullName, Job, Id);
        }

    }
}
