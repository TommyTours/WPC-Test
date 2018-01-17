namespace WPC_Test.Helpers
{
    public class LocationRootObject
    {
        public int status { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public string postcode { get; set; }
        public int quality { get; set; }
        public int eastings { get; set; }
        public int northings { get; set; }
        public string country { get; set; }
        public string nhs_ha { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string european_electoral_region { get; set; }
        public string primary_care_trust { get; set; }
        public string region { get; set; }
        public string lsoa { get; set; }
        public string msoa { get; set; }
        public string incode { get; set; }
        public string outcode { get; set; }
        public string parliamentary_constituency { get; set; }
        public string admin_district { get; set; }
        public string parish { get; set; }
        public object admin_county { get; set; }
        public string admin_ward { get; set; }
        public string ccg { get; set; }
        public string nuts { get; set; }
        public Codes codes { get; set; }
    }

    public class Codes
    {
        public string admin_district { get; set; }
        public string admin_county { get; set; }
        public string admin_ward { get; set; }
        public string parish { get; set; }
        public string parliamentary_constituency { get; set; }
        public string ccg { get; set; }
        public string nuts { get; set; }
    }


    public class CrimeRootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
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