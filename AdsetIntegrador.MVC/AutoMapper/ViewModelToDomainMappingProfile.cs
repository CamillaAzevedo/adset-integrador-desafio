using AdsetIntegrador.MVC.ViewModels;
using AdsetIntegrator.Domain.Entities;
using AutoMapper;

namespace AdsetIntegrador.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Veiculo, VeiculoViewModel>();
            CreateMap<ItemDeSerie, ItemDeSerieViewModel>();
        }
    }
}
