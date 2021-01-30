using System;
using System.Linq;
using AutoMapper;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.Projects;
using BudgetManagementApp.Entities.ViewModels.SubTypes;
using BudgetManagementApp.Entities.ViewModels.Types;
using BudgetManagementApp.Resources.Properties;
using Type = BudgetManagementApp.Entities.Models.Type;

namespace BudgetManagementApp.Entities.Mappings
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Category, CategoryViewModel>()
                .ForMember(destination => destination.Id,
                    member => member.MapFrom(field => field.CategoryId))
                .ForMember(destination => destination.InUse,
                    member => member.MapFrom(field => field.Types.Any(x => !x.DeletedOn.HasValue)));
            CreateMap<CategoryViewModel, Category>();

            CreateMap<Type, TypeViewModel>()
                .ForMember(destination => destination.Id,
                    member => member.MapFrom(field => field.TypeId))
                .ForMember(destination => destination.CategoryDescription,
                    member => member.MapFrom(field => field.Category.Description))
                .ForMember(destination => destination.InUse,
                    member => member.MapFrom(field => field.SubTypes.Any(x => !x.DeletedOn.HasValue)));
            CreateMap<TypeViewModel, Type>();

            CreateMap<SubType, SubTypeViewModel>()
                .ForMember(destination => destination.Id,
                    member => member.MapFrom(field => field.SubTypeId))
                .ForMember(destination => destination.TypeDescription,
                    member => member.MapFrom(field => field.Type.Description))
                .ForMember(destination => destination.CategoryId,
                    member => member.MapFrom(field => field.Type.CategoryId))
                .ForMember(destination => destination.CategoryDescription,
                    member => member.MapFrom(field => field.Type.Category.Description))
                .ForMember(destination => destination.InUse,
                    member => member.MapFrom(field => field.AccountingMovements.Any(x => !x.DeletedOn.HasValue)));
            CreateMap<SubTypeViewModel, SubType>();

            CreateMap<Project, ProjectViewModel>()
                .ForMember(destination => destination.Id,
                    member => member.MapFrom(field => field.ProjectId))
                //.ForMember(destination => destination.StartDate,
                //    member => member.MapFrom(field => field.StartDate.Value.ToString(StringResources.DateFormat)))
                //.ForMember(destination => destination.EndDate,
                //    member => member.MapFrom(field => field.EndDate.Value.ToString(StringResources.DateFormat)))
                .ForMember(destination => destination.InUse,
                    member => member.MapFrom(field => field.AccountingMovements.Any(x => !x.DeletedOn.HasValue)));
            CreateMap<ProjectViewModel, Project>();
            //.ForMember(destination => destination.StartDate,
            //    member => member.MapFrom(field => Convert.ToDateTime(field.StartDate)))
            //.ForMember(destination => destination.EndDate,
            //    member => member.MapFrom(field => Convert.ToDateTime(field.EndDate)));

            //CreateMap<Assignment, ItemTypeResponse>()
            //    .ForMember(destination => destination.ItemId,
            //        member => member.MapFrom(field => field.AssignmentId))
            //    .ForMember(destination => destination.Description,
            //        member => member.MapFrom(field => $"{field.Store.Name.ToUpper()} - {field.Description}"))
            //    .ForMember(destination => destination.Type,
            //        member => member.MapFrom(field => ItemType.Assignment));
        }
    }
}