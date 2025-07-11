namespace KaininLTDWebApp.Controllers
{
    public class ShoppingController
    {
        private readonly HttpClient _httpClient;

        public ShoppingController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        
    }
}
