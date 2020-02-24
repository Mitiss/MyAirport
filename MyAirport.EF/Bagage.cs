using System;
using System.Collections.Generic;
using System.Text;

namespace MyAirport.EF
{
    class Bagage
    {

        public int bagageID { get; set; }
        public int volID { get; set; }
        public string codeIATA { get; set; }
        public string classe { get; set; }
        public string sta { get; set; }
        public string ssur { get; set; }
        public string destination { get; set; }
        public string escale { get; set; }
        public bool prioritaire { get; set; }
        public DateTime dateCreation { get; set; }

        public Bagage()
        {

        }
    }
}
