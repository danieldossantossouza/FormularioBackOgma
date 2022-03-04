using AutoMapper;
using QuestionarioApp.ViewModels;
using QuestionarioBisiness.Models;

namespace QuestionarioApp.AutoMapper
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig()
		{
			CreateMap<Formulario, FormularioViewModel>().ReverseMap();
		}
	}
}
