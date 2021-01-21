using System;
using System.Collections.Generic;
using BudgetManagementApp.Entities.Enums;
using BudgetManagementApp.Resources.Properties;

namespace BudgetManagementApp.Entities.ViewModels
{
    public abstract class BaseViewModel
    {
        public int Id { get; set; }

        public ActionType Action => SetAction();

        public DateTime? DeletedOn { get; set; }

        public bool InUse { get; set; }

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

        public bool IsSuccess()
        {
            return this is Success<bool>;
        }

        public bool IsSuccess<TModel>()
        {
            return this is Success<TModel>;
        }

        public TModel GetSuccessModel<TModel>()
        {
            return AsSuccess<TModel>().Model;
        }

        public bool HasValidations()
        {
            return this is Validation;
        }

        public IEnumerable<string> GetValidations()
        {
            return AsValidation().ValidationErrors;
        }

        public bool Failed()
        {
            return this is Failure;
        }

        public string GetFailureError()
        {
            return AsFailure().ErrorMessage;
        }

        private Success<TModel> AsSuccess<TModel>()
        {
            return this as Success<TModel>;
        }

        private Validation AsValidation()
        {
            return this as Validation;
        }

        private Failure AsFailure()
        {
            return this as Failure;
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
            ErrorMessage = string.Format(
                StringResources.ProccessingError, 
                errorMessage
            );
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