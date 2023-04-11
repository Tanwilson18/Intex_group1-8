using System;
using System.Linq;

namespace Intex_group1_8.Models.ViewModels
{
	public class BurialmainViewModel
	{
        public IQueryable<Burialmain> Burialmains { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}

