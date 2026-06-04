using GemBox.Document;


public class InvoiceModel
{
    public int Number { get; set; } = 1000;
    public DateTime Date { get; set; } = DateTime.Today;
    public string Company { get; set; } = "ACME Corp.";
    public string Address { get; set; } = "240 Old Country Road, Springfield, United States";
    public string Name { get; set; } = "Joe Smith";
    public string Format { get; set; } = "DOCX";
    public SaveOptions Options => this.FormatMappingDictionary[this.Format];
    public virtual IDictionary<string, SaveOptions> FormatMappingDictionary => new Dictionary<string, SaveOptions>()
    {
        ["PDF"] = new PdfSaveOptions(),
        ["DOCX"] = new DocxSaveOptions(),
        ["ODT"] = new OdtSaveOptions(),
        ["HTML"] = new HtmlSaveOptions() { EmbedImages = true },
        ["MHTML"] = new HtmlSaveOptions() { HtmlType = HtmlType.Mhtml },
        ["RTF"] = new RtfSaveOptions(),
        ["XML"] = new XmlSaveOptions(),
        ["TXT"] = new TxtSaveOptions(),


        //["XPS"] = new XpsSaveOptions(),
        //["PNG"] = new ImageSaveOptions(ImageSaveFormat.Png),
        //["JPG"] = new ImageSaveOptions(ImageSaveFormat.Jpeg),
        //["BMP"] = new ImageSaveOptions(ImageSaveFormat.Bmp),
        //["GIF"] = new ImageSaveOptions(ImageSaveFormat.Gif),
        //["TIF"] = new ImageSaveOptions(ImageSaveFormat.Tiff)
    };
}
