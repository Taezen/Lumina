// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MateriaJoinRate", columnHash: 0x69674979 )]
    public partial class MateriaJoinRate : ExcelRow
    {
        
        public float[] NQOvermeldPctSlot { get; set; }
        public float[] HQOvermeldPctSlot { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            NQOvermeldPctSlot = new float[ 4 ];
            for( var i = 0; i < 4; i++ )
                NQOvermeldPctSlot[ i ] = parser.ReadColumn< float >( 0 + i );
            HQOvermeldPctSlot = new float[ 4 ];
            for( var i = 0; i < 4; i++ )
                HQOvermeldPctSlot[ i ] = parser.ReadColumn< float >( 4 + i );
        }
    }
}