// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ActionTransient", columnHash: 0x0e6be68c )]
    public partial class ActionTransient : ExcelRow
    {
        
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Description = parser.ReadColumn< SeString >( 0 );
        }
    }
}