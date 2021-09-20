﻿using LivrariaControleEmprestimo.DATA.Services;
using LivrariaControleEmprestimos.DATA.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaControleEmpestimo.WEB.Controllers
{
    
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oClienteService.oRepositoryCliente.Incluir(model);
            return RedirectToAction("Index");

        }

        public IActionResult Details(int id)
        {
           Cliente  oCliente = oClienteService.oRepositoryCliente.SelecionarPk(id);
            return View(oCliente);

        }
    }
}