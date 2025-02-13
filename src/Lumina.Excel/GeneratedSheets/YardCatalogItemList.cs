// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "YardCatalogItemList", columnHash: 0x7e054231 )]
    public partial class YardCatalogItemList : ExcelRow
    {
        
        public LazyRow< YardCatalogCategory > Category { get; set; }
        public LazyRow< Item > Item { get; set; }
        public ushort Patch { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Category = new LazyRow< YardCatalogCategory >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< int >( 1 ), language );
            Patch = parser.ReadColumn< ushort >( 2 );
        }
    }
}