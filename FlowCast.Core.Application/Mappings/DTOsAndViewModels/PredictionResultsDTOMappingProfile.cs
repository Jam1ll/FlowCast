using AutoMapper;
using FlowCast.Core.Application.DTOs.PredictionResults;
using FlowCast.Core.Application.ViewModels.PredictionData;

namespace FlowCast.Core.Application.Mappings.DTOsAndViewModels
{
    public class PredictionResultsDTOMappingProfile : Profile
    {
        public PredictionResultsDTOMappingProfile()
        {
            CreateMap<PredictionResultsDTO, PredictionDataViewModel>().ReverseMap();
            CreateMap<PredictionResultsDTO, SavePredictionDataViewModel>().ReverseMap();
            CreateMap<PredictionResultsDTO, DeletePredictionDataViewModel>().ReverseMap()
                .ForMember(dest => dest.PredictionMode, opt => opt.Ignore())
                .ForMember(dest => dest.Description, opt => opt.Ignore())
                .ForMember(dest => dest.DateAdded, opt => opt.Ignore())
                .ForMember(dest => dest.PredictionDataId, opt => opt.Ignore())
                .ForMember(dest => dest.PredictionData, opt => opt.Ignore());
        }
    }
}
