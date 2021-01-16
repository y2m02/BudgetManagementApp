using System.Linq;
using BudgetManagementApp.Entities.Models;

namespace BudgetManagementApp.Repositories.Repositories
{
    public interface ITestRepository
    {
        string GetMessage();
    }

    public class TestRepository : BaseRepository, ITestRepository
    {
        private readonly BudgetManagementAppContext _context;

        public TestRepository(BudgetManagementAppContext context)
        {
            _context = context;
        }

        public string GetMessage()
        {
            return "klk";
        }
    }
}
