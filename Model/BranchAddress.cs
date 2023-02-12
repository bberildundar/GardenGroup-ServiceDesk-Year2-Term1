using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model 
{
    [Serializable]
    public class BranchAddress
    {
        [BsonElement("street")]
        string Street { get; set; }

        [BsonElement("zipCode")]
        string ZipCode { get; set; }

        [BsonElement("city")]
        string City { get; set; }
        public BranchAddress(string street,string zip, string city)
        {
            Street = street;
            ZipCode = zip;
            City = city;
        }
        public BranchAddress()
        {

        }

        public BranchAddress ConvertToBranchAddress(string text) //converting to detailed address
        {
            BranchAddress branchAddress;
            switch (text)
            {
                case "Hoofdorp":
                    return branchAddress = new BranchAddress("Waddenweg 100", "2134XL", "Hoofdorp");
                case "Amsterdam":
                    return branchAddress = new BranchAddress("Plantage Kerkstraat 92", "1018PT", "Amsterdam");
                case "Alkmaar":
                    return branchAddress = new BranchAddress("Bankastraat 56", "6621TL", "Alkmaar");
                case "Haarlem":
                    return branchAddress = new BranchAddress("Koningsstraat 20", "5752AL", "Haarlem");
                case "Amstelveen":
                    return branchAddress = new BranchAddress("Paleisstraat 103", "5850PM", "Amstelveen");
                case "Almere":
                    return branchAddress = new BranchAddress("Molstraat 2", "2405AR", "Almere");
                case "Rotterdam":
                    return branchAddress = new BranchAddress("Schoolstraat 15", "7540CR", "Rotterdam");
                case "The Hague":
                    return branchAddress = new BranchAddress("Voorstraat 34", "7036FY", "The Hague");
                case "Delft":
                    return branchAddress = new BranchAddress("Westeinde 8", "1625DO", "Delft");
                case "Dordrecht":
                    return branchAddress = new BranchAddress("Zuideinde 32", "1948NW", "Dordrecht");
                default:
                    break;
            }
            return branchAddress = new BranchAddress("Not specified", "Not specified", "Not specified");
        }
    }
}
