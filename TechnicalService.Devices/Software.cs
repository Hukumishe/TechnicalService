using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Devices
{
    public class Software
    {
        public string SoftwareName { get; set; }
        public DateTime InstallationDate { get; set; }
        public DateTime Guarantee { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return string.Format("\n\tНазвание ПО: {0}\n\tДата установки: {1}\n\tГранатия до: {2}\n\tСтоимость: {3}\n"
                , SoftwareName, InstallationDate, Guarantee, Price);
        }
    }
}
