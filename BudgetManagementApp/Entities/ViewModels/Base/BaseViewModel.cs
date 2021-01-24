using System;
using System.Collections.Generic;
using BudgetManagementApp.Entities.Enums;

namespace BudgetManagementApp.Entities.ViewModels.Base
{
    public abstract class BaseViewModel : BaseReturnViewModel
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

        public abstract IEnumerable<string> Validate();
    }
}