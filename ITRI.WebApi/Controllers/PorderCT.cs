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
    [Route("pOrder/[action]")]
    [ApiController]
    public class POrderCT : ControllerBase
    {
        private readonly IPorderS _porderS;
        private readonly JWTSettings _jwtSettings;

        public POrderCT(IOptions<Settings> settings)
        {
            _porderS = new PorderS(settings.Value.JWTSettings);
            _jwtSettings = settings.Value.JWTSettings;
        }

        [HttpPost]
        public IActionResult GetAll([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());
            var accountId = int.Parse(param["accountId"].ToString());

            var result = _porderS.GetAll(Start, Length, accountId);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult GetById([FromBody]JObject param)
        {
            var id = int.Parse(param["id"].ToString());

            var result = _porderS.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Update([FromBody]Porder param)
        {
            _porderS.Update(param);
            return Ok("success");

        }



        [HttpPost]
        public IActionResult Create([FromBody]Porder param)
        {
            _porderS.Create(param);
            return Ok(param);
        }


        [HttpPost]
        public IActionResult Delete([FromBody]JObject param)
        {

            _porderS.Delete(int.Parse(param["id"].ToString()));
            return Ok("success");
        }


    
    
    }
}