using AutoMapper;
using MathProject.Dtos;
using MathProject.Models;

namespace MathProject.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NumberInfo, NumberToDisplayDto>();
        }
    }
}
