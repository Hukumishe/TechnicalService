using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Organizations
{
    public class Auxiliary
    {
        public string Name { get; set; }
        public List<string> ContactInfo { get; set; }
        public string Id { get; set; }

        public override string ToString()
        {
            foreach (var item in ContactInfo)
            {
                Console.WriteLine(item);
            }

            return string.Format("Имя / Название: {0}\nID: {1}\n", Name, Id);
        }
    }
}
