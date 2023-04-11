using System;
namespace Intex_group1_8.Models.ViewModels
{
	public class PageInfo
	{
        public int TotalNumResults { get; set; }
        public int ResultsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)TotalNumResults / ResultsPerPage);
    }
}

