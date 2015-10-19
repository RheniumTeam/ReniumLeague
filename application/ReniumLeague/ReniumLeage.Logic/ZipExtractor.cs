namespace ReniumLeage.Logic
{
    using Ionic.Zip;

    public class ZipExtractor
    {
        public ZipExtractor(string zipFilePath, ExtractExistingFileAction extractionStratedy = ExtractExistingFileAction.OverwriteSilently)
        {
            this.Path = zipFilePath;
            this.ExtractionStrategy = extractionStratedy;
        }

        public string Path { get; set; }

        public ExtractExistingFileAction ExtractionStrategy { get; set; }

        public void Extract(string destinationFolderPath)
        {
            using (var zip = new ZipFile(this.Path))
            {
                zip.ExtractAll(destinationFolderPath, this.ExtractionStrategy);
            }
        }
    }
}
