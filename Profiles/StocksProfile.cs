using AssessmentTest.Dto;
using AssessmentTest.Model;
using AutoMapper;

namespace AssessmentTest.Profiles
{
    public class CommandsProfiles : Profile
    {
        public CommandsProfiles()
        {
             CreateMap<Stock, Dto.StockReadDto>();
            // CreateMap<CommandCreateDto, Command>();

        }
    }
}