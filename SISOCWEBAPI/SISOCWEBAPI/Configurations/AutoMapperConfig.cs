using AutoMapper;
using SISOC.Business.Models;
using SISOCWEBAPI.DTOs;

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
			CreateMap<Modulo, ModuloDTO>().ReverseMap();
			CreateMap<Ocorrencia, OcorrenciaDTO>().ReverseMap();
			CreateMap<Permissao, PermissaoDTO>().ReverseMap();
			CreateMap<TipoOcorrencia, TipoOcorrenciaDTO>().ReverseMap();
			CreateMap<TipoUsuario, TipoUsuarioDTO>().ReverseMap();
		}
	}
}
