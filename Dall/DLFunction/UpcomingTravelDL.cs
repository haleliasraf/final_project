using DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DL.DLFunction
{
    internal class UpcomingTravelD
    {
        //private readonly IDataSource data;
        //public UpcomingTravelD(IDataSource _data)
        //{
        //    data = _data;
        //}
        DriverDbContext UpcomingTravelCntext = new DriverDbContext();

        public bool AddUpcomingTravel(UpcomingTravel travel )
        {
            try
            {
                UpcomingTravelCntext.UpcomingTravels.Add ( travel);
                UpcomingTravelCntext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

                throw ex;
            }
        }
    }
}
