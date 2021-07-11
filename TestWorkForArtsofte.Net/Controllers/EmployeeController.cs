using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
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
        public IActionResult Add([FromServices] IDepartmentService departmentService, [FromServices] IProgrammingLanguageService programmingLanguageService)
        {
            AddSelectLists(departmentService, programmingLanguageService);

            return View(new EmployeeEditViewModel());
        }

        [Route("Add")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add([FromServices] IDepartmentService departmentService, [FromServices] IProgrammingLanguageService programmingLanguageService, EmployeeEditViewModel model)
        {
            if (ModelState.IsValid && model.Department > 0 && model.ProgrammingLanguage > 0)
            {
                try
                {
                    _service.Add(_mapper.Map<EmployeeDto>(model));

                    return RedirectToAction(nameof(Get));
                }
                catch
                {
                    TempData["Message"] = $"Не получилось добавить нового сотрудника";
                }
            }

            AddSelectLists(departmentService, programmingLanguageService);

            return View(model);
        }

        [Route("edit")]
        [HttpGet]
        public IActionResult Edit(int id, [FromServices] IDepartmentService departmentService, [FromServices] IProgrammingLanguageService programmingLanguageService)
        {
            AddSelectLists(departmentService, programmingLanguageService);

            return View(_mapper.Map<EmployeeEditViewModel>(_service.Get(id)));
        }

        [Route("edit")]
        [HttpPost]
        public IActionResult Edit(EmployeeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.Edit(_mapper.Map<EmployeeDto>(model));

                    RedirectToAction(nameof(Get));
                }
                catch
                {
                    TempData["Message"] = $"Не получилось изменить сотрудника с ID = {model.ID}";
                }
            }

            return RedirectToAction(nameof(Edit), new { id = model.ID });
        }


        private void AddSelectLists(IDepartmentService departmentService, IProgrammingLanguageService programmingLanguageService)
        {
            ViewBag.Departments = GetSelectList(departmentService.Get()
                 .Select(d => _mapper.Map<SimpleSelectViewModel>(d)));

            ViewBag.ProgrammingLanguages = GetSelectList(programmingLanguageService.Get()
                 .Select(pl => _mapper.Map<SimpleSelectViewModel>(pl)));
        }

        private SelectList GetSelectList(IEnumerable items)
        {
            return new SelectList(items, nameof(SimpleSelectViewModel.ID), nameof(SimpleSelectViewModel.Info));
        }
    }
}
