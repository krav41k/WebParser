namespace readlightnovel_parser.core
{
    public interface IParserSettings
    {
        string BaseUrl { get; set; }
        string Prefix { get; set; }
        int StartPoint { get; set; }
        int EndPoint { get; set; }
    }
}