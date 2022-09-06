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
		}
	}
}
