using AdsetIntegrador.MVC.ViewModels;
using AdsetIntegrator.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using AdsetIntegrator.Domain.Entities;
using AutoMapper;

namespace AdsetIntegrador.MVC.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculoAppService _veiculoAppService;

        public VeiculoController(IVeiculoAppService veiculoAppService)
        {
            _veiculoAppService = veiculoAppService;
        }

        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Veiculo>, IEnumerable<VeiculoViewModel>>(_veiculoAppService.GetAll());
            return View(clienteViewModel);
        }

        public ActionResult Details(int id)
        {
            var veiculo = _veiculoAppService.GetbyId(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);

            return View(veiculoViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

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

        public ActionResult Edit(int id)
        {
            var veiculo = _veiculoAppService.GetbyId(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);

            return View(veiculoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VeiculoViewModel veiculo, List<IFormFile> formFileMultiple)
        {
            if (ModelState.IsValid)
            {
                List<string> files = new List<string>();
                
                if (formFileMultiple.Count > 0)
                {
                    foreach (var foto in formFileMultiple)
                    {
                        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/FotosVeiculos");

                        //create folder if not exist
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);
                        string fileNameWithPath = Path.Combine(path, foto.FileName);

                        using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                        {
                            foto.CopyTo(stream);
                        }

                        files.Add(foto.FileName);
                    }
                }
                veiculo.Foto = files;

                var veiculoDomain = Mapper.Map<VeiculoViewModel, Veiculo>(veiculo);
                _veiculoAppService.Update(veiculoDomain);

                return RedirectToAction("Index");
            }
            return View(veiculo);
         
        
    }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            var veiculo = _veiculoAppService.GetbyId(id);
            _veiculoAppService.Delete(veiculo);

            return Json(new { success = true });
        }
    }
}
