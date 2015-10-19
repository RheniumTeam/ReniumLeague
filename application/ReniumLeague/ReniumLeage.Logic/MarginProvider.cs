namespace PdfReportExporter
{
    using Spire.Pdf.Graphics;

    public class MarginProvider
    {
        public MarginProvider(float topMargin, float leftMargin)
        {
            PdfUnitConvertor unitCvtr = new PdfUnitConvertor();
            this.Margins = new PdfMargins();
            this.Margins.Top = unitCvtr.ConvertUnits(topMargin, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            this.Margins.Bottom = this.Margins.Top;
            this.Margins.Left = unitCvtr.ConvertUnits(leftMargin, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            this.Margins.Right = this.Margins.Left;
        }
        
        public PdfMargins Margins { get; set; }
    }
}
