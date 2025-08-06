using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
using MODEL;
using MODEL.Dto;
using Models.Entity;
using Services.Ýnterface;

namespace Services
{
    public class RegisterService : IRegisterService
    {
        private readonly ModelDbContext _context;

        public RegisterService(ModelDbContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterAsync(RegUserDto Userinfo)
        {
            var service = new PasswordHashService();

            User NewUser = new User
            {
                Name = Userinfo.Name,
                Surname = Userinfo.Surname,
                Username = Userinfo.Username,
                DisplayName = Userinfo.DisplayName,
                Email = Userinfo.Email,
                PhoneNumber = Userinfo.PhoneNumber ?? default,
                PasswordHash = service.ComputeHash(Userinfo.Password),
            };

            await _context.Users.AddAsync(NewUser);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}