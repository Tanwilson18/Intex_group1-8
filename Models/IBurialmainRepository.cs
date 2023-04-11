using System;
using System.Linq;

namespace Intex_group1_8.Models
{
	public interface IBurialmainRepository
	{
		IQueryable<Burialmain> Burialmains { get; }
	}
}

