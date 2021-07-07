using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestWorkForArtsofte.Domain.Data.DTOs;
using TestWorkForArtsofte.Domain.Data.ViewModels;
using TestWorkForArtsofte.Domain.Services.Interfaces;

namespace TestWorkForArtsofte.Net.Controllers
{
    [Route("ProgrammingLanguages")]
    public class ProgrammingLanguageController : Controller
    {
        private readonly IProgrammingLanguageService _service;
        private readonly IMapper _mapper;

        public ProgrammingLanguageController(IProgrammingLanguageService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return View(_service.Get()
                .Select(d => _mapper.Map<ProgrammingLanguageSimpleViewModel>(d)));
        }

        [Route("add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View(new ProgrammingLanguageSimpleViewModel());
        }

        [Route("Add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(ProgrammingLanguageSimpleViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_service.IsUniqueTitle(model.Title))
                {
                    _service.Add(_mapper.Map<ProgrammingLanguageDto>(model));

                    return RedirectToAction(nameof(Get));
                }
                else
                {
                    ModelState.AddModelError(nameof(model.Title), "Язык с таким названием уже существует");
                }
            }

            return View(model);
        }
    }
}
