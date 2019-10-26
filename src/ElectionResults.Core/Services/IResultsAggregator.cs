using System.Threading.Tasks;
using ElectionResults.Core.Models;

namespace ElectionResults.Core.Services
{
    public interface IResultsAggregator
    {
        Task<ElectionResultsData> GetLatestResults(ResultsType type);
        Task<ElectionResultsData> GetElectionResults(string id);
    }
}