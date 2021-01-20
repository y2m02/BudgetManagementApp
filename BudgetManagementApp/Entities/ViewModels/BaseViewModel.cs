using BudgetManagementApp.Entities.Enums;
using System;
using System.Collections.Generic;

namespace BudgetManagementApp.Entities.ViewModels
{
    public abstract class BaseViewModel
    {
        public int Id { get; set; }

        public ActionType Action => SetAction();

        public DateTime? DeletedOn { get; set; }

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

                case Failure error:
                    return (new List<TModel>(), error.ErrorMessage);

                default:
                    return (new List<TModel>(), string.Empty);
            }
        }

        public bool IsSuccess<TModel>()
        {
            return this is Success<TModel>;
        }

        public Success<TModel> AsSuccess<TModel>()
        {
            return this as Success<TModel>;
        }

        public TModel GetSuccessModel<TModel>()
        {
            return AsSuccess<TModel>().Model;
        }

        public bool Failed()
        {
            return this is Failure;
        }

        public Failure AsFailure()
        {
            return this as Failure;
        }

        public string GetFailureError()
        {
            return AsFailure().ErrorMessage;
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

    public class Failure : BaseViewModel
    {
        public Failure(string errorMessage)
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