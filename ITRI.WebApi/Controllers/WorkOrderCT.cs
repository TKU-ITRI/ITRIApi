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
    [Route("workOrder/[action]")]
    [ApiController]
    public class WorkOrderCT : ControllerBase
    {
        private readonly IWorkOrderS _workOrderS;
        private readonly JWTSettings _jwtSettings;

        public WorkOrderCT(IOptions<Settings> settings)
        {
            _workOrderS = new WorkOrderS(settings.Value.JWTSettings);
            _jwtSettings = settings.Value.JWTSettings;
        }

        [HttpPost]
        public IActionResult GetAll([FromBody]JObject param)
        {
            var Start = int.Parse(param["start"].ToString());
            var Length = int.Parse(param["length"].ToString());

            var result = _workOrderS.GetAll(Start, Length);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult GetById([FromBody]JObject param)
        {
            var id = int.Parse(param["id"].ToString());

            var result = _workOrderS.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Update([FromBody]WorkOrder param)
        {
            _workOrderS.Update(param);
            return Ok("success");

        }



        [HttpPost]
        public IActionResult Create([FromBody]WorkOrder param)
        {

            _workOrderS.Create(param);
            return Ok(param);
        }


        [HttpPost]
        public IActionResult Delete([FromBody]JObject param)
        {

            _workOrderS.Delete(int.Parse(param["id"].ToString()));
            return Ok("success");
        }


    
    
    }
}