using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.Departnment;
using Repositorys.DEPARTNMENT;
using System.Formats.Asn1;

namespace AngularEcommers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartnmentController : ControllerBase
    {
        private readonly IDepartnment _departnment;

        public DepartnmentController(IDepartnment departnment)
        {
           _departnment = departnment;
        }


        [HttpPost]
        [Route("AddDepartnmet")]
        public async Task<IActionResult> AddDepartnmetn(AddDepartnemtDTO add)
        {
            if(ModelState.IsValid)
            {
                await _departnment.AddDepartnmetn(add);
                return Ok();    
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete]
        [Route("DeleteDepartnment")]
        public async Task<IActionResult> DeleteDepartnment(int id)
        {
            if(ModelState.IsValid)
            {
                   await _departnment.DeleteDepartnment(id);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut]
        [Route("UpdateDepartnmetn")]
        public async Task<IActionResult> UpdateDepartnmetn(UpdateDepartnmentDTO pd)
        {
            if(ModelState.IsValid)
            {
                await _departnment.UpdateDepartnmetn(pd);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetAllDepartnment")]
        public async Task<ActionResult<List<GetAllDepartnmentDTO>>> GetAllDepartnment()
        {
            try
            {
                var usr=await _departnment.GetAllDepartnment();
                return usr;
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        [Route("GetDepartnmentbyid")]
        public async Task<GetAllDepartnmentDTO> GetDepartnmentbyid(int id)
        {
            try
            {
               var res= await _departnment.GetDepartnmentbyid(id);
                return res; 
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
