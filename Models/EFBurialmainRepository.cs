using System;
using System.Linq;

namespace Intex_group1_8.Models
{
	public class EFBurialmainRepository : IBurialmainRepository
	{
		private intex2Context context { get; set; }

		public EFBurialmainRepository(intex2Context temp)
		{
			context = temp;
		}

		public IQueryable<Burialmain> Burialmains => context.Burialmain;
	}
}

