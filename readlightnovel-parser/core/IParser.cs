using AngleSharp.Html.Dom;

namespace readlightnovel_parser.core
{
    public interface IParser<T> where T :class
    {
        T Parse(IHtmlDocument document);
    };
}