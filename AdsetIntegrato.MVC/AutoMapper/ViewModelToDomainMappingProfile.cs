using AdsetIntegrato.MVC.ViewModels;
using AutoMapper;

namespace AdsetIntegrato.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMapping"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            var configuration = new MapperConfiguration(cfg => {
                cfg.CreateMap<Veiculo, VeiculoViewModel>();
                cfg.CreateMap<ItemDeSerie, ItemDeSerieViewModel>();
            });

        }
    }
}