using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScaleModeling.WebUI.Controllers
{
    public class WorkController : Controller
    {
        private IRepository<Work> workRepository;

        public WorkController(IRepository<Work> workRepositoryParam)
        {
            this.workRepository = workRepositoryParam;
        }

        public ActionResult Index()
        {
            return View( workRepository.Get.ToList() );
        }

        public ViewResult GetConcreteWork(int workIdParam)
        {
            return View( workRepository.Get.Where( w => w.Id == workIdParam ).ToList() );
        }
    }
}