using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Repository.DoctorDetailServices
{
    public interface IDoctorDetailServices
    {
        Task<List<DoctorDetail>> GetAllDoctorDetails();
    }
}
