using ProjectManagementApp.Repositories.Repositories;

namespace ProjectManagementApp.Services.Services
{
    public interface ITestService
    {
        string GetMessage();
    }
    public class TestService : ITestService
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
