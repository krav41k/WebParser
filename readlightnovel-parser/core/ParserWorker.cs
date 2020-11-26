using System;
using System.Threading.Tasks;
using AngleSharp.Html.Parser;

namespace readlightnovel_parser.core
{
    public class ParserWorker<T> where T : class
    {
        IParser<T> _parser;
        IParserSettings _parserSettings;
        
        public bool IsActive;

        private HtmlLoader _loader;

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;
        
        public IParser<T> Parser
        {
            get => _parser;
            set => _parser = value;
        }

        public IParserSettings Settings
        {
            get => _parserSettings;
            set
            {
                _parserSettings = value;
                _loader = new HtmlLoader(value);
            }
        }

        public ParserWorker(IParser<T> parser)
        {
            this._parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this._parserSettings = parserSettings;
        }

        public void Start()
        {
            IsActive = true;
            Worker();
        }

        public void Abort()
        {
            this.IsActive = false;
        }

        public async void Worker()
        {
            for (int i = _parserSettings.StartPoint; i <= _parserSettings.EndPoint; i++)
            {
                if (!IsActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await _loader.GetSouceByPageId(i);
                var domParser = new HtmlParser();

                var document = domParser.ParseDocument(source);
                
                var result = _parser.Parse(document);
                
                OnNewData?.Invoke(this, result);
            }
            
            OnCompleted?.Invoke(this);
            IsActive = false;
        }
    }
}