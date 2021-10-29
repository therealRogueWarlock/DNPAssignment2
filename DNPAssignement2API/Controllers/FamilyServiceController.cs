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
        
        
        
        
    }
}