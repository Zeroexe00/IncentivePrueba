using Incentive.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Incentive.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public async System.Threading.Tasks.Task<ActionResult> Index(List<Models.Cliente> Clientes)
        {
            if (Clientes != null)
            {
                var clientes = await ClienteService.GetAllAsync("Api/Clientes");
           
            return View(clientes);
            }
            else
            {
                return View(Clientes);
            }
        }

        // GET: Cliente/Details/5
        public async System.Threading.Tasks.Task<ActionResult> Details(int id)
        {
            var cliente = await ClienteService.GetOneAsync("Api/Clientes", id);
            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public async System.Threading.Tasks.Task<ActionResult> Delete(int id, List<Models.Cliente> clientes)
        {
            
             var Clientes = await ClienteService.GetAllAsync("Api/Clientes");
             Models.Cliente actual = Clientes.Where(model => model.codigo == id).First();

             Clientes.Remove(actual);

            return View("Index", Clientes);

            
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
