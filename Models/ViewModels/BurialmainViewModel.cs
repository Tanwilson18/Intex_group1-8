using System;
using System.Linq;

namespace Intex_group1_8.Models.ViewModels
{
	public class BurialmainViewModel
	{
        public IQueryable<Burialmain> Burialmains { get; set; }
        public IQueryable<BurialmainTextile> BurialmainTextiles { get; set; }
        public IQueryable<Textile> Textiles { get; set; }
        public IQueryable<ColorTextile> ColorTextiles { get; set; }
        public IQueryable<Color> Colors { get; set; }
        public IQueryable<StructureTextile> StructureTextiles { get; set; }
        public IQueryable<Structure> Structures { get; set; }
        public IQueryable<TextilefunctionTextile> TextilefunctionTextiles { get; set; }
        public IQueryable<Textilefunction> Textilefunctions { get; set; }
        public IQueryable<Photodata> Photodatas { get; set; }
        public IQueryable<PhotodataTextile> PhotodataTextiles { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}

