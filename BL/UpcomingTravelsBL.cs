//using Dall;
using DL.DLFunction;
using DL.Models;
//using Eintitees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UpcomingTravelsBL
    {
        public UpcomingTravelsBL( IUserDL userDL)
        {
            UserDL = userDL;
          //  AddUpcomingTravels = addUpcomingTravels;
        }

        private IUserDL UserDL;
        public UpcomingTravelsBL(UpcomingTravel UpcomingTravel)
        {
            //this.UpcomingTravelCntext = userDl;
        }

        public UpcomingTravel AddUpcomingTravels(User user)
        {
            //  return UserDL.AddUser(user);
            return new UpcomingTravel();
        }

      
    }
}
