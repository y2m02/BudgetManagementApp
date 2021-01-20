using System.Linq;
using AutoMapper;
using BudgetManagementApp.Entities.Models;
using BudgetManagementApp.Entities.ViewModels.Categories;

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
                    member => member.MapFrom(field => field.Types.Any()));
            CreateMap<CategoryViewModel, Category>();
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