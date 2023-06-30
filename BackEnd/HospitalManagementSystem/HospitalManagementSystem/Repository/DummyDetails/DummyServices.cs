using Bware.Auth;
using HospitalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace HospitalManagementSystem.Repository.DummyDetails
{
    public class DummyServices : IDummyServices
    {
        private DBContext _context;
        public DummyServices(DBContext context) {
            _context = context;
                }

        public async Task<List<DoctorDummys>> GetDoctorDetails()
        {
            var details = await _context.DoctorDummys.ToListAsync();
            return details;
        }

        public async Task<List<DoctorDummys>> PostDoctor(DoctorDummys doctorDummys)
        {
            var details = _context.DoctorDummys.Add(doctorDummys);
            _context.SaveChanges();
            return await _context.DoctorDummys.ToListAsync();
        }

       public async Task<DoctorDummys?> DeleteDoctor(string id)
        {
            var details=_context.DoctorDummys.FirstOrDefaultAsync(x=>x.User==id);
            _context.Remove(details);
            _context.SaveChanges();
            return null;
        }

    }
}
