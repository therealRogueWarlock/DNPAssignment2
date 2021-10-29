using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DNPAssignement2API.Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace DNPAssignement2API.Controllers
{
    
    
    [ApiController]
    [Route("[controller]")]
    public class FamilyServiceController : ControllerBase
    {

        private IFamilyService familyService;

        public FamilyServiceController(IFamilyService familyService)
        {
            this.familyService = familyService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Family>>> GetFamilies()
        {
            try
            {

                IList<Family> families = await familyService.GetFamilies();
                return Ok(families);

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            
        }


        [HttpDelete]
        [Route("{familyId:int}")]
        public async Task<ActionResult> removeFamily([FromRoute] int familyId )
        {

            try
            {
                
                await familyService.RemoveFamily(familyId);

                return Ok($"Familey with id: {familyId}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            
        }



        [HttpPost]
        public async Task<ActionResult<Family>> AddFamily([FromBody] Family family)
        {

            try
            {
                await familyService.AddFamily(family);

                return Created($"/{family.FamilyId}", family);

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return StatusCode(500, e.Message);


            }
            
            
        }


    }
}