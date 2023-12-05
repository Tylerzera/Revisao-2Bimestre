using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
	public class DomainToApplication : Profile
	{
		public DomainToApplication()
		{
			CreateMap<DocumentosCarta, CartaViewModel>();
		}
	}
}