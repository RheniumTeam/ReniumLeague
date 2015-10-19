namespace ReniumLeage.Logic
{
    using System;
    using System.Data;
    using System.Data.OleDb;

    public class ExcelReader
    {
        public const string ConnectionStringFormat = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

        public void ReadExcelData(string excelFilePath)
        {
            var connectionString = string.Format(ConnectionStringFormat, excelFilePath);

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

            }
        }
    }
}
