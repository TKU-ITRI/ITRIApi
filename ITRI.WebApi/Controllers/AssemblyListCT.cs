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
    [Route("assemblyList/[action]")]
    [ApiController]
    public class AssemblyListCT : ControllerBase
    {
        private readonly IAssemblyListS _assemblyListS;
        private readonly JWTSettings _jwtSettings;

        public AssemblyListCT(IOptions<Settings> settings)
        {
            _assemblyListS = new AssemblyListS(settings.Value.JWTSettings);
            _jwtSettings = settings.Value.JWTSettings;
        }

        [HttpPost]
        public IActionResult GetAll([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());

            var result = _assemblyListS.GetAll(Start, Length);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult GetById([FromBody]JObject param)
        {
            var id = int.Parse(param["id"].ToString());

            var result = _assemblyListS.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Update([FromBody]AssemblyList param)
        {
            _assemblyListS.Update(param);
            return Ok("success");

        }



        [HttpPost]
        public IActionResult Create([FromBody]AssemblyList param)
        {

            _assemblyListS.Create(param);
            return Ok(param);
        }


        [HttpPost]
        public IActionResult Delete([FromBody]JObject param)
        {

            _assemblyListS.Delete(int.Parse(param["id"].ToString()));
            return Ok("success");
        }


    
    
    }
}