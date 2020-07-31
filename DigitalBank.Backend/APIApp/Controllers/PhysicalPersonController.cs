using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIApp.Controllers
{
    [Route("PF")]
    [ApiController]
    public class PhysicalPersonController : ControllerBase
    {
        private readonly IPhysicalPersonAppService _physicalPersonAppService;

        public PhysicalPersonController(IPhysicalPersonAppService physicalPersonAppService)
        {
            _physicalPersonAppService = physicalPersonAppService;
        }
     
        //[HttpGet("/Register")]
        //public async Task<IActionResult> Register()
        //{
        //    try
        //    {
        //       var result = _physicalPersonAppService.GetAllAsync();
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.StackTrace);
        //    }
        //}

        //[HttpPost("/Register")]
        //public async Task<IActionResult> Register(PhysicalPersonViewModel model)
        //{
        //    try
        //    {
        //        _physicalPersonAppService.AddOrUpdate(model);
        //        return Ok(true);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.StackTrace);
        //    }

        //}
    }
}
