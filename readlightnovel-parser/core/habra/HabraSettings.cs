using readlightnovel_parser.core;

namespace readlightnovel_parser.habra
{
    public class HabraSettings : IParserSettings
    {
        public HabraSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        
        public string BaseUrl { get; set; } = "https://habrahabr.ru";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}