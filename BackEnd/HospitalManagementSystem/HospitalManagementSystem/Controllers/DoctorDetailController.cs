using HospitalManagementSystem.Models;
using HospitalManagementSystem.Repository.DoctorDetailServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorDetailController : ControllerBase
    {
        private readonly IDoctorDetailServices _context;
        public DoctorDetailController(IDoctorDetailServices context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<List<DoctorDetail>> GetAllDoctorDetails()
        {
            return await _context.GetAllDoctorDetails();
        }

    }
}
