using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Repository.DoctorDetailServices
{
    public interface IDoctorDetailServices
    {
        Task<List<DoctorDetail>> GetAllDoctorDetails();
        Task<DoctorDetail> DeleteDoctor(int id);
        Task<List<DoctorDetail>> PostDoctorDetails(DoctorDetail doctorDetail);
    }
}
