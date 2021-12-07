using AutoMapper;

using TenyoTech.MealPreparation.Data.Models;
using TenyoTech.MealPreparation.Import.Models.Meals;

namespace TenyoTech.MealPreparation.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Import.Models.tests.Create, commands.tests.Create.Command>();

            CreateMap<Meal, ReadDTOs.Models.tests.Read>();

            CreateMap<CreateMeal, commands.Meals.Create.Command>();

            CreateMap<Meal, ReadDTOs.Models.Meals.ReadMeal>();
        }
    }
}