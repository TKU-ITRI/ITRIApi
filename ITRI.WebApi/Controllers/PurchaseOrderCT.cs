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
    [Route("purchaseOrder/[action]")]
    [ApiController]
    public class PurchaseOrderCT : ControllerBase
    {
        private readonly IPurchaseOrderS _purchaseOrderS;
        private readonly JWTSettings _jwtSettings;

        public PurchaseOrderCT(IOptions<Settings> settings)
        {
            _purchaseOrderS = new PurchaseOrderS(settings.Value.JWTSettings);
            _jwtSettings = settings.Value.JWTSettings;
        }

        [HttpPost]
        public IActionResult GetAll([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());

            var result = _purchaseOrderS.GetAll(Start, Length);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult GetById([FromBody]JObject param)
        {
            var id = int.Parse(param["id"].ToString());

            var result = _purchaseOrderS.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Update([FromBody]PurchaseOrder param)
        {
            _purchaseOrderS.Update(param);
            return Ok("success");

        }



        [HttpPost]
        public IActionResult Create([FromBody]PurchaseOrder param)
        {

            _purchaseOrderS.Create(param);
            return Ok(param);
        }


        [HttpPost]
        public IActionResult Delete([FromBody]JObject param)
        {

            _purchaseOrderS.Delete(int.Parse(param["id"].ToString()));
            return Ok("success");
        }


    
    
    }
}