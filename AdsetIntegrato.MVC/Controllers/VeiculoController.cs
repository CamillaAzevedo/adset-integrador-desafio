using AdsetIntegrato.MVC.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdsetIntegrator.Application;

namespace AdsetIntegrato.MVC.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculoAppService _veiculoAppService;

        public VeiculoController(IVeiculoAppService veiculoAppService)
        {
            _veiculoAppService = veiculoAppService;
        }

        // GET: Veiculo
        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Veiculo>, IEnumerable<VeiculoViewModel>>(_veiculoAppService.GetAll());
            return View(clienteViewModel);
        }

        // GET: Veiculo/Details/5
        public ActionResult Details(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);

            return View(veiculoViewModel);
        }

        // GET: Veiculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veiculo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VeiculoViewModel veiculo)
        {
            if (ModelState.IsValid)
            {
                var veiculoDomain = Mapper.Map<VeiculoViewModel, Veiculo>(veiculo);
                _veiculoAppService.Add(veiculoDomain);

                return RedirectToAction("Index");
            }
            return View(veiculo);
        }

        // GET: Veiculo/Edit/5
        public ActionResult Edit(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);

            return View(veiculoViewModel);
        }

        // POST: Veiculo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VeiculoViewModel veiculo)
        {
            if (ModelState.IsValid)
            {
                var veiculoDomain = Mapper.Map<VeiculoViewModel, Veiculo>(veiculo);
                _veiculoAppService.Update(veiculoDomain);

                return RedirectToAction("Index");
            }
            return View(veiculo);
        }

        // GET: Veiculo/Delete/5
        public ActionResult Delete(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);

            return View(veiculoViewModel);
        }

        // POST: Veiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            _veiculoAppService.Delete(veiculo);

            return RedirectToAction("Index");
        }
    }
}
