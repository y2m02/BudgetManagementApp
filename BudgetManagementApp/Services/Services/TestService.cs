using System.Threading.Tasks;
using BudgetManagementApp.Repositories.Repositories;

namespace BudgetManagementApp.Services.Services
{
    public interface ITestService
    {
        Task<string> GetMessage();
    }
    public class TestService : BaseService, ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public async Task<string> GetMessage()
        {
            return await _testRepository.GetMessage();
        }
    }
}
