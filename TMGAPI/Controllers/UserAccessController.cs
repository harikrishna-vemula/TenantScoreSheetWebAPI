using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMGAPI.BusinessLayer.IServices;

namespace TMGAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccessController : ControllerBase
    {
        private readonly IUserAccessService _userAccessService;
        public UserAccessController(IUserAccessService userAccessService)
        {
            _userAccessService = userAccessService;
        }
        /// <summary>
        /// Login Implementation
        /// </summary>
        /// <returns></returns>
        [HttpGet("TestLogin")]
        public async Task<IActionResult> TestLogin()
        {
            return Ok(await _userAccessService.LoginTest());
        }
    }
}
