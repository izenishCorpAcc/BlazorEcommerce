using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiTestController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product{Id=1,
            Title="Nord CE3",
            Description="Octa-core (1x2.7 GHz Cortex-A78 & 3x2.4 GHz Cortex-A78 & 4x1.8 GHz Cortex-A55)",
            ImageURL="https://fdn2.gsmarena.com/vv/bigpic/oneplus-nord-ce3-5g.jpg",
            Price=600},
             new Product{Id=2,
            Title="Nord 3",
            Description="The OnePlus Nord 3 is finally here! It's been over two years since Nord 2 hit the shelves and it seems the wait was worth it. The third Nord brings a flagship-grade Fluid AMOLED, the top-of-the-line Dimensity 9000 5G chip, and an improved primary camera with a high-end Sony IMX890 sensor.",
            ImageURL="https://fdn2.gsmarena.com/vv/bigpic/oneplus-nord-3r.jpg",
            Price=450},

             new Product{Id=3,
            Title="Nord N30",
            Description="The Nord N30 5G is the latest entry in the Nord N line but is far from an unfamiliar device. The Nord N30 5G is actually the US device name for the OnePlus Nord CE 3 Lite - an identical device meant for Europe and Asia that we've already reviewed. Digging a bit deeper, it is not hard to spot the similarities between the Nord N30 5G and the Realme 10 Pro.",
            ImageURL="https://fdn2.gsmarena.com/vv/bigpic/oneplus-nord-n30-5g.jpg",
            Price=299},

             new Product{Id=4,
            Title="Ace 2V",
            Description="Mediatek MT6983 Dimensity 9000 (4 nm)",
            ImageURL="https://fdn2.gsmarena.com/vv/bigpic/oneplus-ace-2v.jpg",
            Price=200
             }
        };
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(products);
        }
    }
}
