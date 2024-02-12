﻿using DL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DLFunction
{
    public class DriverDL : IDriverDL
    {
        private DriverDbContext _driverContext;
        public DriverDL(DriverDbContext driverContext)
        {
            _driverContext = driverContext;
        }
        //
        public async Task<Driver> AddDriver(Driver driver)
        {
            try
            {
                _driverContext.Drivers.Add(driver);
                await _driverContext.SaveChangesAsync();
                return driver;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //1141414


        public async Task<List<Driver>> GetDriver()
        {
            try
            {

                List<Driver> driver = await _driverContext.Drivers.ToListAsync();

                return driver;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public async Task<Driver> GetById(int Driver_id)
        {
            try
            {
                Driver driver = await _driverContext.Drivers.FindAsync(Driver_id);

                return driver;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<Driver> updateDriver(Driver driver)
        {
            try
            {
                _driverContext.Drivers.Update(driver);
                Driver _driver = await _driverContext.Drivers.FirstOrDefaultAsync(x => x.Id == driver.Id);

                return driver;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex + "userDL_update");
                return null;
            }
        }


        public async Task<bool> DeleteDriver(int User_id)
        {
            try
            {
                Driver _user = await _driverContext.Drivers.FirstOrDefaultAsync(x => x.Id == User_id);
                _driverContext.Drivers.Remove(_user);

                return true;
            }
            catch (Exception ex)
            {
                return false;//לבדוק איל אפשר לעשות בצורה יותר 

                throw ex;
            }
        }


    }
}
