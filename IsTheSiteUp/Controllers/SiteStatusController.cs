using IsTheSiteUp.Entities.DTOs;
using IsTheSiteUp.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace IsTheSiteUp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteStatusController : ControllerBase
    {
        private readonly Interfaces.IHttpClientFactory _httpClientFactory;

        public SiteStatusController(Interfaces.IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost]
        public async Task<ActionResult> GetSiteStatus([FromBody][Required] StatusCheckDto statusDto)
        {
            if (statusDto.Site.IsInvalidUrl())
            {
                return BadRequest("URL is invalid. Please make sure it is present and starts with http security protocol");
            }

            var statusResponseDto = new StatusCheckResponseDto
            {
                Site = statusDto.Site,
                IsUp = await _httpClientFactory.IsGetRequestSuccessful(statusDto.Site)
            };

            return Ok(statusResponseDto);
        }
    }
}