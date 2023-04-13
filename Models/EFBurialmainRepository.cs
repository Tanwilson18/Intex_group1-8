using System;
using System.Linq;

namespace Intex_group1_8.Models
{
	public class EFBurialmainRepository : IBurialmainRepository
	{
		public intex2Context context { get; set; }

		public EFBurialmainRepository(intex2Context temp)
		{
			context = temp;
		}

		public IQueryable<Burialmain> Burialmains => context.Burialmain;
        public IQueryable<BurialmainTextile> BurialmainTextiles => context.BurialmainTextile;
        public IQueryable<Textile> Textiles => context.Textile;
        public IQueryable<TextilefunctionTextile> TextilefunctionTextiles => context.TextilefunctionTextile;
        public IQueryable<Textilefunction> Textilefunctions => context.Textilefunction;
        public IQueryable<ColorTextile> ColorTextiles => context.ColorTextile;
        public IQueryable<Color> Colors => context.Color;
        public IQueryable<StructureTextile> StructureTextiles => context.StructureTextile;
        public IQueryable<Structure> Structures => context.Structure;
    }
}

