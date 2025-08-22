using AutoMapper;
using FlowCast.Core.Application.DTOs.PredictionData;
using FlowCast.Core.Domain.Entities;

namespace FlowCast.Core.Application.Mappings.EntitiesAndDTOs
{
    public class PredictionDataMappingProfile : Profile
    {
        public PredictionDataMappingProfile()
        {
            CreateMap<PredictionData, PredictionDataDTO>().ReverseMap();
        }
    }
}
