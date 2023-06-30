using Bware.Auth;
using HospitalManagementSystem.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Repository.DoctorDetailServices
{
    public class DoctorDetailServices : IDoctorDetailServices
    {
        private DBContext _context;
        public DoctorDetailServices(DBContext context)
        {
            _context = context;
        }

        public async Task<List<DoctorDetail>> GetAllDoctorDetails()
        {
            var details = await _context.DoctorDetail.ToListAsync();
            return details;
        }
    }
}
