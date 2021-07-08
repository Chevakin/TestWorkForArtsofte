using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using TestWorkForArtsofte.Domain.Data.DTOs;
using TestWorkForArtsofte.Domain.Data.ViewModels;
using TestWorkForArtsofte.Domain.Services.Interfaces;

namespace TestWorkForArtsofte.Net.Controllers
{
    [Route("")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            var dtos = _service
                .Get()
                .Select(dto => _mapper.Map<EmployeeDisplayViewModel>(dto));

            return View(dtos);
        }

        [Route("add")]
        [HttpGet]
        public IActionResult Add([FromServices]IDepartmentService departmentService, [FromServices]IProgrammingLanguageService programmingLanguageService)
        {
            ViewBag.Departments = new SelectList(departmentService.Get()
                .Select(d => _mapper.Map<SimpleSelectViewModel>(d)), "ID", "Info");

            ViewBag.ProgrammingLanguages = new SelectList(programmingLanguageService.Get()
                .Select(p => _mapper.Map<SimpleSelectViewModel>(p)), "ID", "Info");

            return View(new EmployeeEditViewModel());
        }

        [Route("Add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(EmployeeEditViewModel model)
        {
            if (ModelState.IsValid && model.Department > 0 && model.ProgrammingLanguage > 0)
            {
                _service.Add(_mapper.Map<EmployeeDto>(model));

                return RedirectToAction(nameof(Get));
            }

            return View(model);
        }
    }
}
