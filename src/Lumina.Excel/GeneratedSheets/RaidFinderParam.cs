// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RaidFinderParam", columnHash: 0x37d885d6 )]
    public partial class RaidFinderParam : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
        }
    }
}