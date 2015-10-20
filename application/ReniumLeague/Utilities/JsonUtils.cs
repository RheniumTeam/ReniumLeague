namespace Utilities
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using RheniumLeague.DtoModels;
    using MSSqul.Data;
    using Newtonsoft.Json;

    public static class JsonUtils
    {
        private const string SaveFilePath = @"..\..\..\Data Sources\JSON\";

        public static void JsonCreateReports()
        {
            var repo = new MSSqlRepo();

            var stadiumReports = repo.GetStadiumReport();

            foreach (var report in stadiumReports)
            {
                SaveReport(report, report.Name.Trim());
            }

            Process.Start(SaveFilePath);
        }

        private static void SaveReport(DtoStadiumReport report, string teamName)
        {
            var jsonReport = JsonConvert.SerializeObject(report, Formatting.Indented);
            File.WriteAllText(SaveFilePath + teamName + ".json", jsonReport);
        }
    }
}