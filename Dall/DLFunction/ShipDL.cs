using DL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DLFunction
{
    public class ShipDL
    {
        private DriverDbContext _driverContext;


        public ShipDL(DriverDbContext driverContext)
        {
            _driverContext = driverContext;
        }
        //
        public async Task<Ship> AddShip(Ship ship)
        {
            try
            {
                _driverContext.Ships.Add(ship);
                await _driverContext.SaveChangesAsync();
                return ship;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Ship>> GetShip()
        {
            try
            {

                List<Ship> _ships = await _driverContext.Ships.ToListAsync();

                return _ships;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<Ship> GetByIdShip(int ship_id)
        {
            try
            {
                Ship ship = await _driverContext.Ships.FindAsync(ship_id);

                return ship;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<Ship> updateShip(Ship ship)
        {
            try
            {
                _driverContext.Ships.Update(ship);
                Ship _ship = await _driverContext.Ships.FirstOrDefaultAsync(x => x.Id == ship.Id);

                return _ship;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex + "userDL_update");
                return null;
            }
        }


        public async Task<bool> DeleteShip(int ship_id)
        {
            try
            {
                Ship _ship = await _driverContext.Ships.FirstOrDefaultAsync(x => x.Id == ship_id);
                _driverContext.Ships.Remove(_ship);

                return true;
            }
            catch (Exception ex)
            {
                return false;//לבדוק איל אפשר לעשות בצורה יותר 

                throw ex;
            }
        }

        //public async Task LoginUser(string Name, string Phone, string Password)
        //{
        //    try
        //    {
        //        Area _user = await _driverContext.Areas.FindAsync(Name, Phone, Password);

        //        return;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}}
        //internal class ShipDL
        //{
        //    private readonly IDataSource data;
        //    public ShipDL(IDataSource _data)
        //    {
        //        data = _data;
        //    }
        //}
    }
}
