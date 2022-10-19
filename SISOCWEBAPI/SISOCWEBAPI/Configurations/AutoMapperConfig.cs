using AutoMapper;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;
using SISOCWEBAPI.ViewModels;

namespace SISOCWEBAPI.Configurations
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig()
		{
			CreateMap<Usuario, UsuarioRegistroDTO>().ReverseMap();
			CreateMap<Usuario, UsuarioLoginDTO>().ReverseMap();
			CreateMap<Setor, SetorDTO>().ReverseMap();
			CreateMap<Anexo, AnexoDTO>().ReverseMap();
			CreateMap<InteracaoOcorrencia, InteracaoOcorrenciaDTO>().ReverseMap();
			CreateMap<Menu, MenuDTO>().ReverseMap();
			CreateMap<Submenu, SubmenuDTO>().ReverseMap();
			CreateMap<Ocorrencia, OcorrenciaDTO>().ReverseMap();
			CreateMap<Permissao, PermissaoDTO>().ReverseMap();
			CreateMap<TipoOcorrencia, TipoOcorrenciaDTO>().ReverseMap();
			CreateMap<TipoUsuario, TipoUsuarioDTO>().ReverseMap();
			CreateMap<Usuario, UsuarioDTO>().ReverseMap();
			CreateMap<OcorrenciaViewModel, Ocorrencia>().ReverseMap()
				.ForMember(o => o.UsuarioAtribuido, map => map.MapFrom(om => om.UsuarioAtribuidoNavigation))
				.ForMember(o => o.UsuarioCadastro, map => map.MapFrom(om => om.UsuarioCadastroNavigation))
				.ForMember(o => o.Setor, map => map.MapFrom(om => om.SetorNavigation))
				.ForMember(o => o.TipoOcorrencia, map => map.MapFrom(om => om.TipoOcorrenciaNavigation))
				.ForMember(o => o.Urgencia, map => map.MapFrom(om => om.UrgenciaENUM))
				.ForMember(o => o.Situacao, map => map.MapFrom(om => om.SituacaoENUM));
		}
	}
}
