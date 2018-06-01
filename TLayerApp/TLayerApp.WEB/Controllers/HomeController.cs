using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TLayerApp.BLL.Interfaces;
using TLayerApp.BLL.DTO;
using TLayerApp.BLL.Infrastructure;
using TLayerApp.WEB.Models;
using AutoMapper;

namespace TLayerApp.WEB.Controllers
{
    public class HomeController : Controller
    {
        IMedalService medalService;

        public HomeController(IMedalService service)
        {
            medalService = service;
        }

        public ActionResult Index()
        {
            IEnumerable<UserDTO> userDTOs = medalService.GetUsers();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, UserViewModel>()).CreateMapper();
            var users = mapper.Map<IEnumerable<UserDTO>, List<UserViewModel>>(userDTOs);
            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        
        public ActionResult AssignMedal(int id)
        {
            MedalDTO medal = medalService.GetMedal(id);
            medalService.AssignMedal(medal);
            return View(medalService.GetUsers());
        }
    }
}