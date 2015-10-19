namespace PdfReportExporter
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using Spire.Pdf;
    using Spire.Pdf.Graphics;
    using Spire.Pdf.Tables;

    public class PdfProvider
    {public PdfProvider(SqlConnection dbCon, MarginProvider marginProvider, Font font)
        {
            this.Document = new PdfDocument();
            this.BrushColor = PdfBrushes.Black;
            this.Margin = marginProvider.Margins;
            this.Font = font;
            this.TrueTypeFont = new PdfTrueTypeFont(this.Font);
            this.Alignment = new PdfStringFormat(PdfTextAlignment.Center);
            this.DbCon = dbCon;
            this.Page = this.Document.Pages.Add(PdfPageSize.A4, this.Margin);
        }

        public void CreatePdf(string filePath, string query)
        {
            Console.WriteLine("Creating PDF Report...");

            var table = DesignPdfTable(this.BrushColor);
            table.DataSourceType = PdfTableDataSourceType.TableDirect;
            table.DataSource = GetTableData(query);

            float width = this.Page.Canvas.ClientSize.Width - (table.Columns.Count + 1) * table.Style.BorderPen.Width;
            foreach (PdfColumn column in table.Columns)
            {
                column.Width = width * 0.24f * width;
                column.StringFormat = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
            }

            table.Draw(this.Page, new PointF(0, this.DistanceFromTop));

            this.Document.SaveToFile(filePath);
            this.Document.Close();

            Console.WriteLine("PDF Report created!");
        }

        public PdfDocument Document { get; set; }

        public PdfPageBase Page { get; set; }

        public MarginProvider MarginProvider { get; set; }

        public PdfMargins Margin { get; set; }

        public float DistanceFromTop { get; set; }
        
        public PdfBrush BrushColor { get; set; }

        public Font Font { get; set; }

        public PdfTrueTypeFont TrueTypeFont { get; set; }

        private PdfStringFormat Alignment { get; set; }

        private SqlConnection DbCon { get; set; }

        public void SetHeader(string text, int marginTop)
        {
            this.Page.Canvas.DrawString(text, this.TrueTypeFont, this.BrushColor, this.Page.Canvas.ClientSize.Width/2,
                this.DistanceFromTop, this.Alignment);
            this.DistanceFromTop = this.DistanceFromTop +
                                   this.TrueTypeFont.MeasureString(text, this.Alignment).Height;
            this.DistanceFromTop = this.DistanceFromTop + marginTop;
        }

        private DataTable GetTableData(string query)
        {

            DataTable dataTable = new DataTable();
            this.DbCon.Open();
            using (this.DbCon)
            {
                SqlCommand cmdCategories = new SqlCommand(query, this.DbCon);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmdCategories);
                using (sqlDataAdapter)
                {
                    sqlDataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private PdfTable DesignPdfTable(PdfBrush brushColor)
        {
            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brushColor, 0.75f);
            table.Style.DefaultStyle.BackgroundBrush = PdfBrushes.Gray;
            table.Style.DefaultStyle.Font = new PdfTrueTypeFont(new Font("Arial", 10f));
            table.Style.AlternateStyle = new PdfCellStyle();
            table.Style.AlternateStyle.BackgroundBrush = PdfBrushes.LightGray;
            table.Style.AlternateStyle.Font = new PdfTrueTypeFont(new Font("Arial", 10f));
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.White;
            table.Style.HeaderStyle.Font = new PdfTrueTypeFont(new Font("Arial", 11f, FontStyle.Bold));
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.ShowHeader = true;

            return table;
        }
    }
}
