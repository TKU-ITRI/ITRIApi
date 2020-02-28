using ITRI.Models.Entities;
using ITRI.Models.Helper;
using ITRI.Services;
using ITRI.Services.Interface;
using ITRI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace ITRI.WebAPI.Controllers
{
    [Route("itriview/[action]")]
    [ApiController]
    public class ITRIViewCT : ControllerBase
    {
        private readonly ITRIViewS _itriview;
        private readonly JWTSettings _jwtSettings;

        public ITRIViewCT(IOptions<Settings> settings)
        {
            _itriview = new ITRIViewS(settings.Value.JWTSettings);
            _jwtSettings = settings.Value.JWTSettings;
        }

        [HttpPost]
        public IActionResult GetAll([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());

            var result = _itriview.GetAll(Start, Length);
            return Ok(result);
        }
       
    }
}