using Microsoft.AspNetCore.Mvc;
using VotingSystemAPI.Mappers;
using VotingSystemAPI.Models.DTOs;
using VotingSystemAPI.Services;

[Route("api/[controller]")]
[ApiController]
public class VotingController : ControllerBase
{
    private readonly IVotingService _votingService;
    private readonly IVoteMapper _voteMapper;

    public VotingController(IVotingService votingService, IVoteMapper voteMapper)
    {
        _votingService = votingService;
        _voteMapper = voteMapper;
    }
    [HttpPost]
    public IActionResult Vote([FromBody] VoteRequestDto voteRequestDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid vote request");
        }

        try
        {
            _votingService.Vote(voteRequestDto.VoterName, voteRequestDto.Candidate, voteRequestDto.BallotType);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet("count/{candidate}")]
    public IActionResult GetVoteCount(string candidate)
    {
        try
        {
            int voteCount = _votingService.GetVoteCount(candidate);
            return Ok(voteCount);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAllVotes()
    {
        try
        {
            var votes = _votingService.GetAllVotes();
            return Ok(votes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}