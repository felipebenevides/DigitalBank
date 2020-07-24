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
    [Route("api/[controller]")]
    [ApiController]
    public class LegalPersonController : ControllerBase
    {
        private readonly ILegalPersonAppService _legalPersonAppService;

        public LegalPersonController(ILegalPersonAppService legalPersonAppService)
        {
            _legalPersonAppService = legalPersonAppService;
        }

        [HttpGet("/Register")]
        public async Task<IActionResult> Register()
        {
            try
            {
                var result = await _legalPersonAppService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.StackTrace);
            }
        }

        [HttpPost("/Register")]
        public async Task<IActionResult> Register(LegalPersonViewModel model)
        {
            try
            {
                _legalPersonAppService.AddOrUpdate(model);
                return Ok(true);
            }
             catch (Exception ex)
            {
                return StatusCode(500, ex.StackTrace);
            }

        }


    }
}
