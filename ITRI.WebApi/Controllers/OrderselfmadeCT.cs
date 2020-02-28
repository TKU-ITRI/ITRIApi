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
    [Route("orderselfmade/[action]")]
    [ApiController]
    public class OrderselfmadeCT : ControllerBase
    {
        private readonly IOrderselfmadeS _orderselfmadeS;
        private readonly JWTSettings _jwtSettings;

        public OrderselfmadeCT(IOptions<Settings> settings)
        {
            _orderselfmadeS = new OrderselfmadeS(settings.Value.JWTSettings);
            _jwtSettings = settings.Value.JWTSettings;
        }

        [HttpPost]
        public IActionResult GetAll([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());
            var Id = int.Parse(param["id"].ToString());

            var result = _orderselfmadeS.GetAll(Start, Length,Id);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult GetById([FromBody]JObject param)
        {
            var id = int.Parse(param["id"].ToString());

            var result = _orderselfmadeS.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Update([FromBody]Orderselfmade param)
        {
            _orderselfmadeS.Update(param);
            return Ok("success");

        }



        [HttpPost]
        public IActionResult Create([FromBody]Orderselfmade param)
        {

            _orderselfmadeS.Create(param);
            return Ok(param);
        }


        [HttpPost]
        public IActionResult Delete([FromBody]JObject param)
        {

            _orderselfmadeS.Delete(int.Parse(param["id"].ToString()));
            return Ok("success");
        }


    
    
    }
}