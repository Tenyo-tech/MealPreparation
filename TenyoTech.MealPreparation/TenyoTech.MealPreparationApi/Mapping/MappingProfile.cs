using AutoMapper;

namespace TenyoTech.MealPreparation.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Import.Models.tests.Create, commands.tests.Create.Command>();
        }
    }
}