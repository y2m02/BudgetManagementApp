using System.Collections.Generic;

namespace BudgetManagementApp.Entities.ViewModels
{
    public interface IViewModel
    {
    }

    public class Success<T> : IViewModel
    {
        public Success(T model)
        {
            Model = model;
        }

        public T Model { get; }
    }

    public class Error : IViewModel
    {
        public Error(string errorMessage)
        {
            ErrorMessage = "Hubo un error durante el proceso. " +
                           $"Por favor, consulte a soporte: \n{errorMessage}";
        }

        public string ErrorMessage { get; }
    }

    public class Validation : IViewModel
    {
        public Validation(IEnumerable<string> validationErrors)
        {
            ValidationErrors = validationErrors;
        }

        public IEnumerable<string> ValidationErrors { get; }
    }
}