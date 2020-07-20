using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;

namespace APIApp.Controllers
{
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionAppService _transactionAppService;

        public TransactionController(ITransactionAppService transactionAppService)
        {
            _transactionAppService = transactionAppService;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllTransaction()
        {
            try
            {
                var result = await _transactionAppService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.StackTrace);
            }
        }

        [HttpGet("GetAll/Type/")]
        public async Task<IActionResult> GetAllTransactionByType([FromQuery] string type)
        {
            try
            {
                var result =  await _transactionAppService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.StackTrace);
            }
        }

        [HttpPost("CreateTransaction")]
        public async Task<IActionResult> CreateTransaction([FromBody] HistoryTransactionViewModel model)
        {
            try
            {
                 _transactionAppService.AddOrUpdate(model);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.StackTrace);
            }
        }
    }
}
