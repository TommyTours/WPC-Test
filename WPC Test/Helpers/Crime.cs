using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WPC_Test.Helpers
{
    public class Crime
    {
        public string category { get; set; }
        public string location_type { get; set; }
        public CrimeLocation location { get; set; }
        public string context { get; set; }
        public Outcome_Status outcome_status { get; set; }
        public string persistent_id { get; set; }
        public int id { get; set; }
        public string location_subtype { get; set; }
        public string month { get; set; }
    }
}