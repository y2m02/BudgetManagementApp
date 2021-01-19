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
                    member => member.MapFrom(field => field.CategoryId));
            CreateMap<CategoryViewModel, Category>();
            //    .ForMember(destination => destination.Used,
            //        member => member.MapFrom(field => field.Assignments.Count > 0));
            //CreateMap<StoreRequest, Store>();
            //CreateMap<UpdateStoreRequest, Store>();
            //CreateMap<DeleteStoreRequest, Store>();


            //CreateMap<Store, ItemTypeResponse>()
            //    .ForMember(destination => destination.ItemId,
            //        member => member.MapFrom(field => field.StoreId))
            //    .ForMember(destination => destination.Description,
            //        member => member.MapFrom(field => field.Name))
            //    .ForMember(destination => destination.Type,
            //        member => member.MapFrom(field => ItemType.Store));

            //CreateMap<Assignment, ItemTypeResponse>()
            //    .ForMember(destination => destination.ItemId,
            //        member => member.MapFrom(field => field.AssignmentId))
            //    .ForMember(destination => destination.Description,
            //        member => member.MapFrom(field => $"{field.Store.Name.ToUpper()} - {field.Description}"))
            //    .ForMember(destination => destination.Type,
            //        member => member.MapFrom(field => ItemType.Assignment));

            //CreateMap<Status, ItemTypeResponse>()
            //    .ForMember(destination => destination.ItemId,
            //        member => member.MapFrom(field => field.StatusId))
            //    .ForMember(destination => destination.Description,
            //        member => member.MapFrom(field => field.Description))
            //    .ForMember(destination => destination.Type,
            //        member => member.MapFrom(field => ItemType.Status));
        }
    }
}