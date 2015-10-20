using PdfReportExporter;

namespace ReniumLeague.Entity
{
    using System;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
   // using PdfReportExporter;

    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var db = new RheniumSportsEntities())
            {
                var match = new Match();
                match.Attendnce = 0;
                db.Matches.Add(match);
                Console.WriteLine(db.Matches.FirstOrDefault());
            }

            var dbCon = new SqlConnection("Server=.\\SQLEXPRESS; Database=TelerikAcademy; Integrated Security=true");
            var margin = new MarginProvider(2.54f, 3.17f);
            var font = new Font("Arial", 16f, FontStyle.Bold);
            var pdfProvider = new PdfProvider(dbCon, margin, font);
            pdfProvider.SetHeader("Rhenium League", 50);
            pdfProvider.CreatePdf("../../Reports/PdfReport.pdf", "SELECT TOP 100 FirstName, LastName, Salary FROM Employees");
        }
    }
}
