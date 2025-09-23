using System.Reflection;

namespace LeadSoft.Adapter.BrasilAPI
{
    /// <summary>
    /// Brasil API integration
    /// </summary>
    public partial class BrasilApi : IBrasilApi
    {
        private readonly HttpClient _Client;
        private const string _BaseURL = "https://brasilapi.com.br/api/";

        /// <summary>
        /// Constructor
        /// </summary>
        public BrasilApi()
        {
            _Client = new HttpClient
            {
                BaseAddress = new Uri(_BaseURL)
            };
            _Client.DefaultRequestHeaders.UserAgent.ParseAdd($"LeadSoft.Adapter.BrasilAPI/{Assembly.GetExecutingAssembly().GetName().Version} (+https://www.nuget.org/packages/LeadSoft.Adapter.BrasilAPI)");
        }

        /// <summary>
        /// Dispose Method
        /// </summary>
        public void Dispose()
        {
            _Client.Dispose();
        }
    }
}

