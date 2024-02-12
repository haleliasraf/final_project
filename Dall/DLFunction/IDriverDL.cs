using DL.Models;

namespace DL.DLFunction
{
    public interface IDriverDL
    {
        Task<Driver> AddDriver(Driver driver);
        Task<bool> DeleteDriver(int User_id);
        Task<Driver> GetById(int Driver_id);
        Task<List<Driver>> GetDriver();
        Task<Driver> updateDriver(Driver driver);
    }
}