using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMGAPI.BusinessLayer.IServices;
using TMGAPI.DomainLayer.DataBaseEntities;

namespace TMGAPI.BusinessLayer.Services
{
    public class UserAccessService : IUserAccessService
    {
        private readonly TmgDBContext _dBContext;
        public UserAccessService(TmgDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<bool> LoginTest()
        {
            var test = await _dBContext.TblUsers.ToListAsync();
            return true;
        }
    }
}
