using System;
using Microsoft.ML;

namespace myMLApp
{
    public class Program{

        public class imageData{

            public string filename {get; set;}
            public string date {get; set;}
            public string type {get; set;}
            public string organization {get; set;}
            public string author {get; set;}
            public int plantID {get; set;}
            public taxonData taxon {get; set;}
            public string vernacularName {get; set;}
            public string locality {get; set;}
            public string content {get; set;}
            public GPSData GPSlocality {get; set;} 

        }

        public class taxonData{

            public string regnum {get; set;}
            public string order {get; set;}
            public string family {get; set;}
            public string species {get; set;}
            public string genus {get; set;}

        }

        public class GPSData{
            
            public float longitude {get; set;}
            public float latitude {get; set;}
            public float altitude {get; set;}

        }

        static void Main(string[] args){

           Console.WriteLine("Hello World !");

        }
    }
}
