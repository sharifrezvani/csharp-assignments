
using Microsoft.AspNetCore.Mvc;
using API.Entities;
using API.Controllers;
using API.Data;
using Microsoft.EntityFrameworkCore;
using API.DTO;

namespace API.Controllers
{
    public class UsersController : BaseController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{ID}")]
        public ActionResult<User> GetUserByID(int id)
        {
            return _context.Users.Find(id);
        }

        [HttpPost("ChangeBirthday")]

        public async Task<ActionResult<User>> ChangeBirthday(BirthdayDTO birthdayDTO)
        {

            if (!await Exists(birthdayDTO.ID))
            {
                return BadRequest("User Not Found!");
            }

            DateTime newBirthday = DateTime.Parse(birthdayDTO.Birthday);

            _context.Users.Find(birthdayDTO.ID).Birthday = newBirthday;

            _context.Users.Find(birthdayDTO.ID).Age = DateTime.Now.Subtract(newBirthday).Days / 365;

            User user = _context.Users.Find(birthdayDTO.ID);
            await _context.SaveChangesAsync();

            return user;
        }

        [HttpPost("ChangePhoneNumber")]

        public async Task<ActionResult<User>> ChangeBirthday(PhoneNumberDTO phoneNumberDTO)
        {

            if (!await Exists(phoneNumberDTO.ID))
            {
                return BadRequest("User Not Found!");
            }
            else if (phoneNumberDTO.PhoneNumber.Length != 8 || !phoneNumberDTO.PhoneNumber.All(number => char.IsDigit(number)))
            {
                return BadRequest("Wrong Phone Number Format!");
            }

            _context.Users.Find(phoneNumberDTO.ID).PhoneNumber = phoneNumberDTO.PhoneNumber;

            User user = _context.Users.Find(phoneNumberDTO.ID);

            await _context.SaveChangesAsync();

            return user;
        }



        public async Task<bool> Exists(int id)
        {
            return await _context.Users.AnyAsync(user => user.ID == id);
        }
    }


}