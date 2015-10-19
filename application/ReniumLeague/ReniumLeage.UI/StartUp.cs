namespace ReniumLeage.UI
{
    using Ionic.Zip;
    using System.IO;
    using ReniumLeage.Logic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            ZipReader zipReader = new ZipReader("../../../../../Matches - Results.zip");

            zipReader.Extract("../../../../../");
        }
    }
}
