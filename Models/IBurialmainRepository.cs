using System;
using System.Linq;

namespace Intex_group1_8.Models
{
	public interface IBurialmainRepository
	{
		IQueryable<Burialmain> Burialmains { get; }
        IQueryable<BurialmainTextile> BurialmainTextiles { get; }
        IQueryable<Textile> Textiles { get; }
        IQueryable<ColorTextile> ColorTextiles { get; }
        IQueryable<Color> Colors { get; }
        IQueryable<StructureTextile> StructureTextiles { get; }
        IQueryable<Structure> Structures { get; }
        IQueryable<TextilefunctionTextile> TextilefunctionTextiles { get; }
        IQueryable<Textilefunction> Textilefunctions { get; }
    }
}

