// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GFateClimbing2TotemType", columnHash: 0xd9d6e4fa )]
    public partial class GFateClimbing2TotemType : ExcelRow
    {
        
        public LazyRow< PublicContentTextData > PublicContentTextData { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            PublicContentTextData = new LazyRow< PublicContentTextData >( gameData, parser.ReadColumn< uint >( 0 ), language );
        }
    }
}