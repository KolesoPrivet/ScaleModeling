using System.Linq;
using System.Web.Mvc;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IRepository<Product> productRepository;

        public ShopController(IRepository<Product> productRepositoryParam)
        {
            this.productRepository = productRepositoryParam;
        }

        public ViewResult Index()
        {
            return View(productRepository.GetAll.ToList());
        }

        public ViewResult GetConcreteProduct(int id)
        {
            return View( productRepository.GetAll.Where( p => p.Id == id ).AsEnumerable().First() );
        }
    }
}