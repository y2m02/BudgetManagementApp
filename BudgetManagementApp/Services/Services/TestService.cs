using System.Threading.Tasks;
using AutoMapper;
using BudgetManagementApp.Repositories.Repositories;

namespace BudgetManagementApp.Services.Services
{
    public interface ITestService
    {
        Task<string> GetMessage();
    }
    public class TestService : BaseService, ITestService
    {
        private readonly ITestRepository testRepository;

        public TestService(ITestRepository testRepository, IMapper mapper) : base(mapper)
        {
            this.testRepository = testRepository;
        }

        public async Task<string> GetMessage()
        {
            return await testRepository.GetMessage();
        }
    }
}
