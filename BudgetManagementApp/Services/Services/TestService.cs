using BudgetManagementApp.Repositories.Repositories;

namespace BudgetManagementApp.Services.Services
{
    public interface ITestService
    {
        string GetMessage();
    }
    public class TestService : BaseService, ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public string GetMessage()
        {
            return _testRepository.GetMessage();
        }
    }
}
