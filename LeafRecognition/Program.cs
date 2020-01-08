using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace myMLApp
{
    public class Program{

        [XmlRoot("Image")]
        public class imageData{

            [XmlElement(ElementName="FileName")]
            public string filename {get; set;}
            [XmlElement(ElementName="Date")]
            public string date {get; set;}
            [XmlElement(ElementName="Type")]
            public string type {get; set;}
            [XmlElement(ElementName="Organization")]
            public string organization {get; set;}
            [XmlElement(ElementName="Author")]
            public string author {get; set;}
            [XmlElement(ElementName="IndividualPlantId")]
            public int plantID {get; set;}
            [XmlElement(ElementName="Taxon")]
            public taxonData taxon {get; set;}
            [XmlElement(ElementName="VernacularNames")]
            public string vernacularName {get; set;}
            [XmlElement(ElementName="Locality")]
            public string locality {get; set;}
            [XmlElement(ElementName="Content")]
            public string content {get; set;}
            [XmlElement(ElementName="GPSLocality")]
            public GPSData GPSlocality {get; set;} 

        }

        [XmlRoot("Taxon")]
        public class taxonData{

            [XmlElement(ElementName="Regnum")]
            public string regnum {get; set;}
            [XmlElement(ElementName="Order")]
            public string order {get; set;}
            [XmlElement(ElementName="Family")]
            public string family {get; set;}
            [XmlElement(ElementName="Species")]
            public string species {get; set;}
            [XmlElement(ElementName="Genus")]
            public string genus {get; set;}

        }

        [XmlRoot("GPSLocality")]
        public class GPSData{
            
            [XmlElement(ElementName="Longitude")]
            public float longitude {get; set;}
            [XmlElement(ElementName="Latitude")]
            public float latitude {get; set;}
            [XmlElement(ElementName="Altitude")]
            public float altitude {get; set;}

        }

        static void Main(string[] args){

            //Charger les fichiers XML
            XmlReader reader = XmlReader.Create("../ImageCLEF2011FinalPackage/data/Train/0.xml");
            XmlSerializer ser = new XmlSerializer(typeof(imageData));
            imageData data = (imageData)ser.Deserialize(reader);

            // // Create MLContext
            // MLContext mlContext = new MLContext();
            
            // //Load Data
            // IDataView dataView = mlContext.Data.LoadFromEnumerable<imageData>(data);

        }
    }
}
