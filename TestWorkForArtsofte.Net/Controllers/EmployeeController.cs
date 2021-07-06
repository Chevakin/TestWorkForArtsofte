using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        public JsonResult Get()
        {
            var dtos = _service
                .Get()
                .Select(dto => _mapper.Map<EmployeeDisplayViewModel>(dto));

            return Json(dtos);
        }
    }
}
