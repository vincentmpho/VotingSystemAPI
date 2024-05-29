using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VotingSystemAPI.Models;
using VotingSystemAPI.Services;

namespace VotingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartiesController : ControllerBase
    {
        private readonly PartyService _partyService;

        public PartiesController(PartyService partyService)
        {
            _partyService = partyService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetParties()
        {
            var parties = _partyService.GetParties();
            return Ok(parties);
        }

        [HttpGet("ballotTypes")]
        public ActionResult<IEnumerable<string>> GetBallotTypes()
        {
            var ballotTypes = new List<string>
        {
            "National Regional",
            "Regional National",
            "Provincial"
        };
            return Ok(ballotTypes);
        }
    }
}