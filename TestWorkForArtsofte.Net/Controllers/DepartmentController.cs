using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWorkForArtsofte.Domain.Data.ViewModels;
using TestWorkForArtsofte.Domain.Services.Interfaces;

namespace TestWorkForArtsofte.Net.Controllers
{
    [Route("Departments")]
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
        public JsonResult Get()
        {
            return Json(_service.Get()
                .Select(d => _mapper.Map<DepartmentViewModel>(d)));
        }
    }
}
