using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.İnterface
{
    public interface IPasswordHashService
    {
        string ComputeHash (string input);
    }
}