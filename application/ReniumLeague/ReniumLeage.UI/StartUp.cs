namespace ReniumLeage.UI
{
    using Ionic.Zip;
    using System.IO;
    using ReniumLeage.Logic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            ZipExtractor zipReader = new ZipExtractor("../../../../../Matches - Results.zip");

            zipReader.Extract("../../../../../");


            MongoRepository mongoContext = new MongoRepository();

            List<ReniumLeague.Entity.Mongo.Models.Team> allPlaces = mongoContext.GetAllTeams().ToList();

            var xmlSerializer = new ReniumLeague.Entity.Serializer.XmlSerialzer();

            var xmlString = xmlSerializer.Serialize < ReniumLeague.Entity.Mongo.Models.Team >> (allTeams);

            var xmlFilePath = "../../teams.xml";

            using (var str = new StreamWriter(xmlFilePath))
            {
                str.Write(xmlString);
            }

            var objectsFromXml = xmlSerializer.ParseXml < ReniumLeague.Entity.Mongo.Models.Team >> (xmlFilePath);

            Console.WriteLine();
        }
    }
}
