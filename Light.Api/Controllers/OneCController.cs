using Light.AppConfig.Controllers;
using Light.Logic.DataTransferObjects.OneC;
using Light.Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace Light.Api.Controllers
{
    public class OneCController : ApiControllerBase
    {
        private readonly IOneCService _oneCService;

        public OneCController(IOneCService oneCService)
        {
            _oneCService = oneCService;
        }

        [HttpPost("DataGenerate")]
        public IActionResult DataGenerate(OneCDto oneC, [FromQuery]bool forceUpdate)
        {
            _oneCService.OneCDataGenerate(oneC, forceUpdate);
            return AsSuccessResult("ok");
        }
    }
}
