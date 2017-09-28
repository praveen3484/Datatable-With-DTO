using AutoMapper;
using DataTableAndDTO.DTO;
using DataTableAndDTO.Models;

namespace DataTableAndDTO.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            CreateMap<Students1, StudentDto>();

            CreateMap<Students1Details, StudentDetailsDto>();


            // Dto to Domain
            CreateMap<StudentDto, Students1>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            //CreateMap<StudentDetailsDto, Students1Details>()
            //    .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}