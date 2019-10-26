using System.Threading.Tasks;
using ElectionResults.Core.Models;
using ElectionResults.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElectionResults.WebApi.Controllers
{
    [Route("api/results")]
    public class ResultsController : Controller
    {
        private readonly IResultsAggregator _resultsAggregator;

        public ResultsController(IResultsAggregator resultsAggregator)
        {
            _resultsAggregator = resultsAggregator;
        }

        [HttpGet("")]
        public async Task<ElectionResultsData> GetLatestResults([FromQuery] ResultsType type)
        {
            return await _resultsAggregator.GetLatestResults(type);
        }

        [HttpGet("{id}")]
        public async Task<ElectionResultsData> GetElectionResults(string id)
        {
            return await _resultsAggregator.GetElectionResults(id);
        }
    }
}
