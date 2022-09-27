using HospitalManagement.Core;
using HospitalManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        public IHospitalManager hospitalManager;
        public HospitalController(IHospitalManager hospitalManager)
        {
            this.hospitalManager = hospitalManager;
        }

        [HttpGet("getAllHospital")]
        public async Task<ActionResult> GetAllHospitals()
        {
            try
            {
                var listHospital = await hospitalManager.GetAllHospitals();
                return Ok(listHospital);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("addHospital")]
        public async Task<ActionResult> AddHospital(Hospital hospital)
        {
            try
            {
                var addedHospital = await hospitalManager.AddNewHospital(hospital);
                return Ok(addedHospital);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
