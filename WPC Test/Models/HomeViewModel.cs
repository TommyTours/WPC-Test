using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using WPC_Test.Helpers;

namespace WPC_Test.Models
{
    public class HomeViewModel
    {
        public List<List<JSONCrime>> crimesByCategory { get; set; }
        public string postcode { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public List<int> months = Enumerable.Range(1, 12).ToList();
        public List<int> years = Enumerable.Range(1900, 118).ToList();
    }
}