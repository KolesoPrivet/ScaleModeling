using System.Linq;
using System.Web.Mvc;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IRepository<Product, int> productRepository;

        public ShopController(IRepository<Product, int> productRepositoryParam)
        {
            this.productRepository = productRepositoryParam;
        }

        public ViewResult Index()
        {
            return View(productRepository.Get.ToList());
        }

        public ViewResult GetConcreteProduct(int id)
        {
            return View( productRepository.Get.Where( p => p.Id == id ).ToList() );
        }
    }
}