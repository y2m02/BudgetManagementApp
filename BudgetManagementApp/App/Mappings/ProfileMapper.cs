using System.Linq;
using AutoMapper;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels.Categories;
using BudgetManagementApp.Entities.ViewModels.Types;

namespace BudgetManagementApp.Mappings
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
            //    .ForMember(destination => destination.Used,
            //        member => member.MapFrom(field => field.Assignments.Count > 0));

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