using MODEL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.İnterface
{
    public interface IRegisterService
    {
        Task<bool> RegisterAsync(RegUserDto Userinfo);
    }
}