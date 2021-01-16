using System.Linq;
using BudgetManagementApp.Entities.Models;

namespace BudgetManagementApp.Repositories.Repositories
{
    public interface ITestRepository
    {
        string GetMessage();
    }

    public class TestRepository : ITestRepository
    {
        public string GetMessage()
        {
            var context = new ButgetManagementAppContext();

            var students = context.Students.ToList();

            var student = students.FirstOrDefault();

            return "klk";
        }
    }
}
