using System;
using System.Collections.Generic;
using BudgetManagementApp.Entities.Enums;

namespace BudgetManagementApp.Entities.ViewModels
{
    public abstract class BaseViewModel
    {
        public int Id { get; set; }
        public ActionType Action => SetAction();

        protected DateTime? DeletedOn { get; private set; }

        private ActionType SetAction()
        {
            return Id > 0
                ? DeletedOn.HasValue
                    ? ActionType.Delete
                    : ActionType.Update
                : ActionType.Create;
        }

        public void SetDeletedOn()
        {
            DeletedOn = DateTime.Now;
        }

        public (IEnumerable<TModel> model, string error) DownGrade<TModel>()
        {
            switch (this)
            {
                case Success<IEnumerable<TModel>> success:
                    return (success.Model, string.Empty);

                case Error error:
                    return (new List<TModel>(), error.ErrorMessage);

                default:
                    return (new List<TModel>(), string.Empty);
            }
        }
    }

    public class Success<T> : BaseViewModel
    {
        public Success(T model)
        {
            Model = model;
        }

        public T Model { get; }
    }

    public class Error : BaseViewModel
    {
        public Error(string errorMessage)
        {
            ErrorMessage = "Hubo un error durante el proceso. " +
                           $"Por favor, consulte a soporte: \n{errorMessage}";
        }

        public string ErrorMessage { get; }
    }

    public class Validation : BaseViewModel
    {
        public Validation(IEnumerable<string> validationErrors)
        {
            ValidationErrors = validationErrors;
        }

        public IEnumerable<string> ValidationErrors { get; }
    }
}