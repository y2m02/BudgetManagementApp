using AutoMapper;
using BudgetManagementApp.Entities;
using BudgetManagementApp.Entities.ViewModels.AccountingMovements;
using BudgetManagementApp.Entities.ViewModels.Base;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.Projects;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Repositories.Repositories.AccountingMovements;
using BudgetManagementApp.Repositories.Repositories.Categories;
using BudgetManagementApp.Repositories.Repositories.Projects;
using BudgetManagementApp.Repositories.Repositories.SubTypes;
using BudgetManagementApp.Repositories.Repositories.Types;
using BudgetManagementApp.Resources.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace BudgetManagementApp.Services.Services
{
    public interface IDataService
    {
        BaseReturnViewModel GetData();
    }

    public class DataService : IDataService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly ITypeRepository typeRepository;
        private readonly ISubTypeRepository subTypeRepository;
        private readonly IProjectRepository projectRepository;
        private readonly IAccountingMovementRepository accountingMovementRepository;
        private readonly IMapper mapper;
        private readonly IAccessGranterService accessGranter;

        public DataService(
            ICategoryRepository categoryRepository,
            ITypeRepository typeRepository,
            ISubTypeRepository subTypeRepository,
            IProjectRepository projectRepository,
            IAccountingMovementRepository accountingMovementRepository,
            IMapper mapper,
            IAccessGranterService accessGranter
        )
        {
            this.categoryRepository = categoryRepository;
            this.typeRepository = typeRepository;
            this.subTypeRepository = subTypeRepository;
            this.projectRepository = projectRepository;
            this.accountingMovementRepository = accountingMovementRepository;
            this.mapper = mapper;
            this.accessGranter = accessGranter;
        }

        public BaseReturnViewModel GetData()
        {
            return HandleErrors(() =>
            {
                return Success(
                    new DataViewModel
                    {
                        Categories = mapper.Map<IEnumerable<CategoryViewModel>>(
                            categoryRepository.GetAll()
                        ),
                        Types = mapper.Map<IEnumerable<TypeViewModel>>(
                            typeRepository.GetAll()
                        ),
                        SubTypes = mapper.Map<IEnumerable<SubTypeViewModel>>(
                            subTypeRepository.GetAll()
                        ),
                        Projects = mapper.Map<IEnumerable<ProjectViewModel>>(
                            projectRepository.GetAll()
                        ),
                        AccountingMovements = mapper.Map<IEnumerable<AccountingMovementViewModel>>(
                            accountingMovementRepository.GetAll()
                        ),
                    }
                );
            });
        }

        private BaseReturnViewModel HandleErrors(Func<BaseReturnViewModel> executor)
        {
            try
            {
                return executor();
            }
            catch (SqlException ex)
            {
                var message = ex.Message;

                if (message.ToLower().Contains(StringResources.AccessDenied))
                {
                    accessGranter.GrantAccess(
                        AppDomain.CurrentDomain.BaseDirectory,
                        FileSystemRights.FullControl
                    );

                    return executor();
                }

                return new Failure(message);
            }
            catch (Exception ex)
            {
                return new Failure(ex.Message);
            }
        }

        private static BaseReturnViewModel Success<T>(T model)
        {
            return new Success<T>(model);
        }
    }
}
