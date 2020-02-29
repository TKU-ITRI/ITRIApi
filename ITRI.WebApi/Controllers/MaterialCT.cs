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
    [Route("material/[action]")]
    [ApiController]
    public class MaterialCT : ControllerBase
    {
        private readonly IMaterialS _materialS;
        private readonly JWTSettings _jwtSettings;

        public MaterialCT(IOptions<Settings> settings)
        {
            _materialS = new MaterialS(settings.Value.JWTSettings);
            _jwtSettings = settings.Value.JWTSettings;
        }

        [HttpPost]
        public IActionResult GetAll([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());
            var accountId = int.Parse(param["accountId"].ToString());
            var result = _materialS.GetAll(Start, Length, accountId);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult GetById([FromBody]JObject param)
        {
            var id = int.Parse(param["id"].ToString());

            var result = _materialS.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Update([FromBody]Material param)
        {
            _materialS.Update(param);
            return Ok("success");

        }



        [HttpPost]
        public IActionResult Create([FromBody]Material param)
        {

            _materialS.Create(param);
            return Ok(param);
        }


        [HttpPost]
        public IActionResult Delete([FromBody]JObject param)
        {

            _materialS.Delete(int.Parse(param["id"].ToString()));
            return Ok("success");
        }


    
    
    }
}