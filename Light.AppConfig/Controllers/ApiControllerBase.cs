using Light.AppConfig.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Light.AppConfig.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult AsSuccessResult(
                         string message)
                         => AsActionResult<object>(HttpStatusCode.OK, message, null);
        
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult AsSuccessResult<T>(
            string message,
            T? data)
            => AsActionResult(HttpStatusCode.OK, message, data);
        
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult AsSuccessResult<T>(
            T? data)
            => AsActionResult(HttpStatusCode.OK, string.Empty, data);


        [ApiExplorerSettings(IgnoreApi = true)]
        private IActionResult AsActionResult<T>(
            HttpStatusCode statusCode,
            string message,
            T? data)
        {
            var statusCodeAsInt = (int)statusCode;
            var responseModel = new ApiResponse<T>
            {
                Data = data,
                Message = message,
                StatusCode = statusCodeAsInt
            };

            return this.StatusCode(statusCodeAsInt, responseModel);
        }
    }
}
