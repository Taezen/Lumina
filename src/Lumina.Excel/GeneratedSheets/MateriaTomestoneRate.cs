// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MateriaTomestoneRate", columnHash: 0xb366c408 )]
    public partial class MateriaTomestoneRate : ExcelRow
    {
        
        public uint Rate { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Rate = parser.ReadColumn< uint >( 0 );
        }
    }
}