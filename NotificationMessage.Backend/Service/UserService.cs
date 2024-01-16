using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NotificationMessage.Backend.DataContext;
using NotificationMessage.Backend.Model;
using NotificationMessage.Backend.Service.UserDtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NotificationMessage.Backend.Service
{
    public class UserService
    {
        private readonly MyAppDbContext2024 _context;
        private readonly IMapper _mapper;
        public UserService(MyAppDbContext2024 context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<User> Register(AddUserDto addUserDto)
        {
            var exists = await _context.users.AnyAsync(x => x.PhoneNumber == addUserDto.PhoneNumber);
            if (exists)
            {
                return null;
            }
            addUserDto.DateCreated = DateTime.Now;
            var user = _mapper.Map<User>(addUserDto);
            user.WalletUser = new WalletUser()
            {
                SmsBalance = 0,
                WhatsappBalance = 0,
                TelegramBalance = 0,
            };
            await _context.users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetById(int id)
        {
            var user = await _context.users.FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }
        public async Task<User> Update(UpdateUserDto updateUserDto)
        {
            var user = await _context.users.FirstOrDefaultAsync(x => x.Id == updateUserDto.Id);
            await _context.SaveChangesAsync();
            return user;
        }
        public async Task<User> Delete(int id)
        {
            var user = await _context.users.FirstOrDefaultAsync(x => x.Id == id);
            _context.users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }
        public async Task<User> GetPhone(string phone)
        {
            var user = await _context.users.FirstOrDefaultAsync(x => x.PhoneNumber == phone);
            return user;
        }
    }
}
