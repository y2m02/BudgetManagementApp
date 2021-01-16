using System.Threading.Tasks;
using BudgetManagementApp.Entities.Models;

namespace BudgetManagementApp.Repositories.Repositories
{
    public interface ITestRepository
    {
        Task<string> GetMessage();
    }

    public class TestRepository : BaseRepository, ITestRepository
    {
        public TestRepository(BudgetManagementAppContext context) : base(context)
        {
        }

        public async Task<string> GetMessage()
        {
            return "klk";
        }
    }
}