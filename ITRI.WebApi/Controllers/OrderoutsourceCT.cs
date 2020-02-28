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
    [Route("orderoutsource/[action]")]
    [ApiController]
    public class OrderoutsourceCT : ControllerBase
    {
        private readonly IOrderoutsourceS _orderoutsourceS;
        private readonly JWTSettings _jwtSettings;

        public OrderoutsourceCT(IOptions<Settings> settings)
        {
            _orderoutsourceS = new OrderoutsourceS(settings.Value.JWTSettings);
            _jwtSettings = settings.Value.JWTSettings;
        }

        [HttpPost]
        public IActionResult GetAll([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());

            var result = _orderoutsourceS.GetAll(Start, Length);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult GetById([FromBody]JObject param)
        {
            var id = int.Parse(param["id"].ToString());

            var result = _orderoutsourceS.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Update([FromBody]Orderoutsource param)
        {
            _orderoutsourceS.Update(param);
            return Ok("success");

        }



        [HttpPost]
        public IActionResult Create([FromBody]Orderoutsource param)
        {

            _orderoutsourceS.Create(param);
            return Ok(param);
        }


        [HttpPost]
        public IActionResult Delete([FromBody]JObject param)
        {

            _orderoutsourceS.Delete(int.Parse(param["id"].ToString()));
            return Ok("success");
        }


    
    
    }
}