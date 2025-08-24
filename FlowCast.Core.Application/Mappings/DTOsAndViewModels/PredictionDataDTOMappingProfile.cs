using AutoMapper;
using FlowCast.Core.Application.DTOs.PredictionData;
using FlowCast.Core.Application.ViewModels.PredictionData;

namespace FlowCast.Core.Application.Mappings.DTOsAndViewModels
{
    public class PredictionDataDTOMappingProfile : Profile
    {
        public PredictionDataDTOMappingProfile()
        {
            CreateMap<PredictionDataDTO, PredictionDataViewModel>().ReverseMap();
            CreateMap<PredictionDataDTO, SavePredictionDataViewModel>().ReverseMap();
            CreateMap<PredictionDataDTO, DeletePredictionDataViewModel>().ReverseMap()
                .ForMember(dest => dest.Values, opt => opt.Ignore())
                .ForMember(dest => dest.PredictionMode, opt => opt.Ignore());
        }
    }
}
