using ShopifySharp;

namespace KaininLTDWebApp.Controllers
{
    public class AdminController
    {
        private readonly IConfiguration _configuration;
        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task CreateProduct(Product product, bool publish = true)
        {

            var service = new ProductService("m2nku8-tp.myshopify.com", _configuration[""]); //make secret containing token value

            if (publish)
                product = await service.CreateAsync(product);

            //By default, creating a product will publish it. To create an unpublished product:+1:
            else
                product = await service.CreateAsync(product, new ProductCreateOptions() { Published = false });

        }
    }
}
