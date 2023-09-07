using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.Departnment;
using Repositorys.DEPARTNMENT;

namespace AngularEcommers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartnmentController : ControllerBase
    {
        private readonly IDepartnment _Dp;

        public DepartnmentController(IDepartnment Dp)
        {
            _Dp= Dp;
        }


        [HttpPost]
        [Route("AddDepartnment")]
        public async Task<IActionResult> AddDep(AddDepartnemtDTO add)
        {
            if(ModelState.IsValid)
            {
                await _Dp.AddDepartnmetn(add);
                return Ok();    
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete]
        [Route("deleteDepartnment")]
        public async Task<IActionResult> DeleteDep(int id)
        {
            if(ModelState.IsValid)
            {
                   await _Dp.DeleteDepartnment(id);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut]
        [Route("updateDepartnmet")]
        public async Task<IActionResult> updatedepartnment(UpdateDepartnmentDTO pd)
        {
            if(ModelState.IsValid)
            {
                await _Dp.UpdateDepartnmetn(pd);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


    }
}
