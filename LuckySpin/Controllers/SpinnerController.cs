﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using LuckySpin.Services;
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        private RepoService repository;

        /***
         * Controller Constructor
         */
        public SpinnerController()
        {
            //TODO: Inject a RepoService parameter and assign it to the instance variable 'repository'
        }

        /***
         * Entry Page Action
         **/

        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Index(Player player)
        {
            //TODO: Decide whether to redirect to the Spin Action or return to the Index form view, based on ModelState.IsValid

            return RedirectToAction("Spin", player);

        }

        /***
         * Spin Action
         **/  
               
         public IActionResult Spin(Player player)
        {
            return View("Spin", new Spin { Player = player });
        }

        /***
         * ListSpins Action
         **/

         public IActionResult LuckList()
        {
            //TODO: Pass the repository's PlayerSpins property to the LuckList View
                return View();
        }

    }
}

