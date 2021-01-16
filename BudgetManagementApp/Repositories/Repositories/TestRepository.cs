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
        private readonly ButgetManagementAppContext _context;

        public TestRepository(ButgetManagementAppContext context)
        {
            _context = context;
        }

        public string GetMessage()
        {
            var students = _context.Students.ToList();

            var student = students.FirstOrDefault();

            return "klk";
        }
    }
}
