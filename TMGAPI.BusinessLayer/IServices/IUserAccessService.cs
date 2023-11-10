using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMGAPI.BusinessLayer.IServices
{
    public interface IUserAccessService
    {
        Task<bool> LoginTest();
    }
}
