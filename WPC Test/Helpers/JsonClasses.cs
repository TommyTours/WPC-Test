namespace WPC_Test.Helpers
{
   public class CrimeRootobject
    {
        public JSONCrime[] Property1 { get; set; }
    }

    public class JSONCrime
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

    public class CrimeLocation
    {
        public string latitude { get; set; }
        public Street street { get; set; }
        public string longitude { get; set; }
    }

    public class Street
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Outcome_Status
    {
        public string category { get; set; }
        public string date { get; set; }
    }



}