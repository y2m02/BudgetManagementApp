using System.Linq;
using ProjectManagementApp.Entities.Models;

namespace ProjectManagementApp.Repositories.Repositories
{
    public interface ITestRepository
    {
        string GetMessage();
    }

    public class TestRepository : ITestRepository
    {
        public string GetMessage()
        {
            var context = new BaseContext();

            var students = context.Students.ToList();

            var student = students.FirstOrDefault();

            return "klk";
        }
    }
}
