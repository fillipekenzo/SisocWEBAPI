﻿using Microsoft.EntityFrameworkCore;
using SISOC.Business.Interface;
using SISOC.Business.Models;
using SISOC.Business.Models.Interface;
using SISOC.Data.Context;
using System.Linq.Expressions;

namespace SISOC.Data.Repository
{
	public class TipoOcorrenciaRepository : Repository<TipoOcorrencia>, ITipoOcorrenciaRepository
	{
		public TipoOcorrenciaRepository(SisocDbContext db) : base(db)
		{

		}
	}
}
