namespace BlazorAppWithAPI_JPZipCode.Shared
{
    public partial class JpZip
    {
        public string Message { get; set; } = "";

        public Result[]? Results { get; set; }

        public long Status { get; set; }
    }

    public partial class Result
    {
        public string Address1 { get; set; } = "";

        public string Address2 { get; set; } = "";

        public string Address3 { get; set; } = "";

        public string Kana1 { get; set; } = "";

        public string Kana2 { get; set; } = "";

        public string Kana3 { get; set; } = "";

        public long Prefcode { get; set; }

        public string Zipcode { get; set; } = "";
    }
}
