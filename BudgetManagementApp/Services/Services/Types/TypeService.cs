using AutoMapper;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Repositories.Repositories.Base;
using BudgetManagementApp.Repositories.Repositories.Types;
using BudgetManagementApp.Services.Services.Base;

namespace BudgetManagementApp.Services.Services.Types
{
    public class TypeService :
        BaseService<Type, TypeViewModel>,
        ITypeService
    {
        private readonly ITypeRepository typeRepository;

        public TypeService(
            IMapper mapper,
            ITypeRepository typeRepository
        ) : base(mapper)
        {
            this.typeRepository = typeRepository;
        }

        protected override IBaseRepository<Type> Repository => typeRepository;
    }
}