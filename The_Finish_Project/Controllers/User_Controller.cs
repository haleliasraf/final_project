using BL;
using DTO.DTO;
//using Eintitees;
using Microsoft.AspNetCore.Mvc;
using DL.Models;
using DL.DLFunction;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dal_Finish_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User_Controller : ControllerBase
    {
        IUserBL _userBl;
        public User_Controller(IUserBL userBl)
        {
            this._userBl = userBl;
        }

        // GET: api/<User_Controller>
        [HttpGet]
        public async Task<List<UserDTO>> GetUsers()
        {
            List<UserDTO> user = await _userBl.GetUsers();
            return user;
        }

        // GET api/<User_Controller>/5
        [HttpGet("{id}")]
        public async Task<UserDTO> GetById(int id)
        {
            UserDTO user = await _userBl.GetById(id);
            return user;
        }

        // POST api/<User_Controller>
        [HttpPost]
        ///  [Route("Login")]
        public async Task<UserDTO> AddUser([FromBody] UserDTO newUser)
        {
            UserDTO insertedUser = await _userBl.addUser(newUser);
            return insertedUser;
        }

        // PUT api/<User_Controller>/5
        [HttpPut]
        public async Task<UserDTO> Put([FromBody] UserDTO userdto)
        {
            UserDTO user = await _userBl.updatUser(userdto);

            return user;
        }

        // DELETE api/<User_Controller>/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteUser(int id)
        {
            bool user = await _userBl.DeleteUser(id);
            return user;

        }

        [HttpPost]
        [Route("Login")]

        public async Task<UserDTO>LoginUser(string email, string password)
        {
            UserDTO insertedUser = await _userBl.LoginUser(email,password);
            if (insertedUser != null)
            {
                return insertedUser;
            } 
            else {
                throw new Exception("user Not found");
            }
        }
    }

  
  }

