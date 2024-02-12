using DL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DLFunction
{
    public class ContactDL
    {
        private DriverDbContext _driverContext;


        public ContactDL(DriverDbContext driverContext)
        {
            _driverContext = driverContext;
        }
        //
        public async Task<Contact> AddContact(Contact ship)
        {
            try
            {
                _driverContext.Contacts.Add(ship);
                await _driverContext.SaveChangesAsync();
                return ship;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Contact>> GetContact()
        {
            try
            {

                List<Contact> _ships = await _driverContext.Contacts.ToListAsync();

                return _ships;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public async Task<Contact> GetByIdContact(int ship_id)
        {
            try
            {
                Contact ship = await _driverContext.Contacts.FindAsync(ship_id);

                return ship;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<Contact> updateContact(Contact ship)
        {
            try
            {
                _driverContext.Contacts.Update(ship);
                Contact _ship = await _driverContext.Contacts.FirstOrDefaultAsync(x => x.Id == ship.Id);

                return _ship;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex + "userDL_update");
                return null;
            }
        }


        public async Task<bool> DeleteContact(int ship_id)
        {
            try
            {
                Contact _ship = await _driverContext.Contacts.FirstOrDefaultAsync(x => x.Id == ship_id);
                _driverContext.Contacts.Remove(_ship);

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
