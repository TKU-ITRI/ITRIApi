using ITRI.Models.Entities;
using ITRI.Models.Helper;
using ITRI.Services;
using ITRI.Services.Interface;
using ITRI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace QRCode.WebAPI.Controllers
{
    [Route("cm/[action]")]
    [ApiController]
    public class CompanyManageCT : ControllerBase
    {
        private readonly ICompanyManageS _CompanyManageService;
        private readonly JWTSettings _jwtSettings;

        public CompanyManageCT(IOptions<Settings> settings)
        {
            _CompanyManageService = new CompanyManageS(settings.Value.JWTSettings);
            _jwtSettings = settings.Value.JWTSettings;
        }

        [HttpPost]
        public IActionResult GetAll([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());

            var result = _CompanyManageService.GetAll(Start, Length);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult GetAllAccount([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());
            var CompanyId = int.Parse(param["companyId"].ToString());

            var result = _CompanyManageService.GetAllAccount(Start, Length, CompanyId);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAllCompany()
        {
            var result = _CompanyManageService.GetAllCompany();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult GetById([FromBody]JObject param)
        {
            var Id = int.Parse(param["Id"].ToString());

            var result = _CompanyManageService.GetById(Id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Update([FromBody]Company param)
        {
            _CompanyManageService.Update(param);
            return Ok("success");

        }



        [HttpPost]
        public IActionResult Create([FromBody]Company param)
        {

            _CompanyManageService.Create(param);
            return Ok(param);
        }


        [HttpPost]
        public IActionResult Delete([FromBody]JObject param)
        {

            _CompanyManageService.Delete(int.Parse(param["id"].ToString()));
            return Ok("success");
        }


        [HttpPost]
        public IActionResult TurnStatus([FromBody]JObject param)
        {

            _CompanyManageService.TurnStatus(int.Parse(param["id"].ToString()));
            return Ok("success");
        }

    }
}