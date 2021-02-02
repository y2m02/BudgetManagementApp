using AutoMapper;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Repositories.Repositories.Base;
using BudgetManagementApp.Repositories.Repositories.SubTypes;
using BudgetManagementApp.Services.Services.Base;

namespace BudgetManagementApp.Services.Services.SubTypes
{
    public class SubTypeService :
        BaseService<SubType, SubTypeViewModel>,
        ISubTypeService
    {
        private readonly ISubTypeRepository subTypeRepository;

        public SubTypeService(
            IMapper mapper,
            ISubTypeRepository subTypeRepository
        ) : base(mapper)
        {
            this.subTypeRepository = subTypeRepository;
        }

        protected override IBaseRepository<SubType> Repository => subTypeRepository;
    }
}