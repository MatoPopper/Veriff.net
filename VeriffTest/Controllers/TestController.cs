using Microsoft.AspNetCore.Mvc;
using Veriff.net.Internal.Interfaces;
using Veriff.net.Shared;

namespace VeriffTest.Controllers
{
    [ApiController]
    [Route("testController")]
    public class TestController : ControllerBase
    {
        private readonly IVeriffService _veriffService;

        public TestController(IVeriffService veriffService)
        {
            _veriffService = veriffService;
        }

        [HttpGet("createSession")]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            var request = new Veriff.net.Requests.CreateSession
            {
                Verification = new Veriff.net.Requests.Verification
                {
                    Callback = "https://veriff.me",
                    VendorData = "11112222"
                }
            };

            var result = await _veriffService.Sessions.CreateSession(request, cancellationToken);

            return Ok(result);
        }

        [HttpPost("uploadImage")]
        public async Task<IActionResult> UploadImage([FromForm] TestUploadDocument data, CancellationToken cancellationToken)
        {
            if (data.File == null || data.File.Length == 0)
                return BadRequest("No file uploaded.");

            var request = new Veriff.net.Requests.UploadDocument
            {
                Image = new Veriff.net.Requests.Image
                {
                    Context = ContextTypeExtensions.ToContextString(data.ContextType)
                }
            };

            using (var memoryStream = new MemoryStream())
            {
                await data.File.CopyToAsync(memoryStream);
                var fileBytes = memoryStream.ToArray();
                var base64String = Convert.ToBase64String(fileBytes);
                request.Image.Content = base64String;
            }

            var result = await _veriffService.Sessions.UploadDocument(data.SessionId, request, cancellationToken);

            return Ok(result);
        }
    }
}