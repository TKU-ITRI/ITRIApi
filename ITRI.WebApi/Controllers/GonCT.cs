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
    [Route("gon/[action]")]
    [ApiController]
    public class GonCT : ControllerBase
    {
        private readonly IGonS _gonS;
        private readonly JWTSettings _jwtSettings;

        public GonCT(IOptions<Settings> settings)
        {
            _gonS = new GonS(settings.Value.JWTSettings);
            _jwtSettings = settings.Value.JWTSettings;
        }

        [HttpPost]
        public IActionResult GetAll([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());
            var id = int.Parse(param["id"].ToString());

            var result = _gonS.GetAll(Start, Length,id);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult GetById([FromBody]JObject param)
        {
            var id = int.Parse(param["id"].ToString());

            var result = _gonS.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Update([FromBody]Gon param)
        {
            _gonS.Update(param);
            return Ok("success");

        }



        [HttpPost]
        public IActionResult Create([FromBody]Gon param)
        {

            var result = _gonS.Create(param);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult Delete([FromBody]JObject param)
        {

            _gonS.Delete(int.Parse(param["id"].ToString()));
            return Ok("success");
        }


    
    
    }
}