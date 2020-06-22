using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cards.Commands.API.Commands;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cards.Commands.API.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CardsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToCard([FromBody] CreateProductToCardCommand command)
        { 
            try
            { 
                if (!ModelState.IsValid) 
                    return BadRequest(ModelState); 

                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message); 
            }

        }
    }
}
