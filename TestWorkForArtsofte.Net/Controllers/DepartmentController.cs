using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestWorkForArtsofte.Domain.Data.DTOs;
using TestWorkForArtsofte.Domain.Data.ViewModels;
using TestWorkForArtsofte.Domain.Services.Interfaces;

namespace TestWorkForArtsofte.Net.Controllers
{
    [Route("Departments")]
    [Route("api/departments")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _service;
        private readonly IMapper _mapper;

        public DepartmentController(IDepartmentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return View(_service.Get()
                .Select(d => _mapper.Map<DepartmentSimpleViewModel>(d)));
        }

        [Route("add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View(new DepartmentSimpleViewModel());
        }

        [Route("Add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(DepartmentSimpleViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_service.IsUniqueTitle(model.Title))
                {
                    _service.Add(_mapper.Map<DepartmentDto>(model));

                    return RedirectToAction(nameof(Get));
                }
                else
                {
                    ModelState.AddModelError(nameof(model.Title), "Отдел с таким названием уже существует");
                }
            }

            return View(model);
        }
    }
}
