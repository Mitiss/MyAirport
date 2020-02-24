using System;
using System.Collections.Generic;
using System.Text;

namespace MyAirport.EF
{
    class Vol
    {
        public int id { get; set; }
        public int cie { get; set; }
        public int jex { get; set; }
        public int pax { get; set; }
        public string lig { get; set; }
        public string pkg { get; set; }
        public string des { get; set; }
        public string imm { get; set; }
        public DateTime dhc { get; set; }

        public Vol()
        {

        }

    }

  
}
