// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentFinderCondition", columnHash: 0xaec73040 )]
    public partial class ContentFinderCondition : ExcelRow
    {
        
        public SeString ShortCode { get; set; }
        public LazyRow< TerritoryType > TerritoryType { get; set; }
        public byte ContentLinkType { get; set; }
        public ushort Content { get; set; }
        public bool PvP { get; set; }
        public byte Unknown5 { get; set; }
        public uint Unknown6 { get; set; }
        public uint Unknown7 { get; set; }
        public LazyRow< ClassJobCategory > AcceptClassJobCategory { get; set; }
        public LazyRow< ContentMemberType > ContentMemberType { get; set; }
        public byte Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public LazyRow< Quest > UnlockQuest { get; set; }
        public byte Unknown14 { get; set; }
        public uint Unknown15 { get; set; }
        public byte ClassJobLevelRequired { get; set; }
        public byte ClassJobLevelSync { get; set; }
        public ushort ItemLevelRequired { get; set; }
        public ushort ItemLevelSync { get; set; }
        public bool Unknown20 { get; set; }
        public bool AllowUndersized { get; set; }
        public bool AllowReplacement { get; set; }
        public bool Unknown23 { get; set; }
        public bool AllowExplorerMode { get; set; }
        public bool Unknown25 { get; set; }
        public bool Unknown26 { get; set; }
        public byte Unknown27 { get; set; }
        public bool Unknown28 { get; set; }
        public bool HighEndDuty { get; set; }
        public bool Unknown30 { get; set; }
        public byte Unknown31 { get; set; }
        public bool Unknown32 { get; set; }
        public bool Unknown33 { get; set; }
        public bool DutyRecorderAllowed { get; set; }
        public bool Unknown35 { get; set; }
        public bool Unknown36 { get; set; }
        public bool Unknown37 { get; set; }
        public bool Unknown38 { get; set; }
        public SeString Name { get; set; }
        public SeString NameShort { get; set; }
        public LazyRow< ContentType > ContentType { get; set; }
        public byte TransientKey { get; set; }
        public uint Transient { get; set; }
        public ushort SortKey { get; set; }
        public uint Image { get; set; }
        public uint Icon { get; set; }
        public sbyte Unknown47 { get; set; }
        public int Unknown48 { get; set; }
        public bool Unknown49 { get; set; }
        public byte Unknown50 { get; set; }
        public bool LevelingRoulette { get; set; }
        public bool HighLevelRoulette { get; set; }
        public bool MSQRoulette { get; set; }
        public bool GuildHestRoulette { get; set; }
        public bool ExpertRoulette { get; set; }
        public bool TrialRoulette { get; set; }
        public bool DailyFrontlineChallenge { get; set; }
        public bool LevelCapRoulette { get; set; }
        public bool MentorRoulette { get; set; }
        public bool Unknown60 { get; set; }
        public bool Unknown61 { get; set; }
        public bool Unknown62 { get; set; }
        public bool Unknown63 { get; set; }
        public bool Unknown64 { get; set; }
        public bool AllianceRoulette { get; set; }
        public bool FeastTeamRoulette { get; set; }
        public bool NormalRaidRoulette { get; set; }
        public bool Unknown68 { get; set; }
        public bool Unknown69 { get; set; }
        public bool Unknown70 { get; set; }
        public bool Unknown71 { get; set; }
        public bool Unknown72 { get; set; }
        public bool Unknown73 { get; set; }
        public bool Unknown74 { get; set; }
        public bool Unknown75 { get; set; }
        public bool Unknown76 { get; set; }
        public bool Unknown77 { get; set; }
        public bool Unknown78 { get; set; }
        public bool Unknown79 { get; set; }
        public bool Unknown80 { get; set; }
        public bool Unknown81 { get; set; }
        public bool Unknown82 { get; set; }
        public bool Unknown83 { get; set; }
        public bool Unknown84 { get; set; }
        public bool Unknown85 { get; set; }
        public bool Unknown86 { get; set; }
        public bool Unknown87 { get; set; }
        public bool Unknown88 { get; set; }
        public bool Unknown89 { get; set; }
        public bool Unknown90 { get; set; }
        public bool Unknown91 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ShortCode = parser.ReadColumn< SeString >( 0 );
            TerritoryType = new LazyRow< TerritoryType >( gameData, parser.ReadColumn< ushort >( 1 ), language );
            ContentLinkType = parser.ReadColumn< byte >( 2 );
            Content = parser.ReadColumn< ushort >( 3 );
            PvP = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< uint >( 6 );
            Unknown7 = parser.ReadColumn< uint >( 7 );
            AcceptClassJobCategory = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 8 ), language );
            ContentMemberType = new LazyRow< ContentMemberType >( gameData, parser.ReadColumn< byte >( 9 ), language );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            UnlockQuest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 13 ), language );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< uint >( 15 );
            ClassJobLevelRequired = parser.ReadColumn< byte >( 16 );
            ClassJobLevelSync = parser.ReadColumn< byte >( 17 );
            ItemLevelRequired = parser.ReadColumn< ushort >( 18 );
            ItemLevelSync = parser.ReadColumn< ushort >( 19 );
            Unknown20 = parser.ReadColumn< bool >( 20 );
            AllowUndersized = parser.ReadColumn< bool >( 21 );
            AllowReplacement = parser.ReadColumn< bool >( 22 );
            Unknown23 = parser.ReadColumn< bool >( 23 );
            AllowExplorerMode = parser.ReadColumn< bool >( 24 );
            Unknown25 = parser.ReadColumn< bool >( 25 );
            Unknown26 = parser.ReadColumn< bool >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< bool >( 28 );
            HighEndDuty = parser.ReadColumn< bool >( 29 );
            Unknown30 = parser.ReadColumn< bool >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< bool >( 32 );
            Unknown33 = parser.ReadColumn< bool >( 33 );
            DutyRecorderAllowed = parser.ReadColumn< bool >( 34 );
            Unknown35 = parser.ReadColumn< bool >( 35 );
            Unknown36 = parser.ReadColumn< bool >( 36 );
            Unknown37 = parser.ReadColumn< bool >( 37 );
            Unknown38 = parser.ReadColumn< bool >( 38 );
            Name = parser.ReadColumn< SeString >( 39 );
            NameShort = parser.ReadColumn< SeString >( 40 );
            ContentType = new LazyRow< ContentType >( gameData, parser.ReadColumn< byte >( 41 ), language );
            TransientKey = parser.ReadColumn< byte >( 42 );
            Transient = parser.ReadColumn< uint >( 43 );
            SortKey = parser.ReadColumn< ushort >( 44 );
            Image = parser.ReadColumn< uint >( 45 );
            Icon = parser.ReadColumn< uint >( 46 );
            Unknown47 = parser.ReadColumn< sbyte >( 47 );
            Unknown48 = parser.ReadColumn< int >( 48 );
            Unknown49 = parser.ReadColumn< bool >( 49 );
            Unknown50 = parser.ReadColumn< byte >( 50 );
            LevelingRoulette = parser.ReadColumn< bool >( 51 );
            HighLevelRoulette = parser.ReadColumn< bool >( 52 );
            MSQRoulette = parser.ReadColumn< bool >( 53 );
            GuildHestRoulette = parser.ReadColumn< bool >( 54 );
            ExpertRoulette = parser.ReadColumn< bool >( 55 );
            TrialRoulette = parser.ReadColumn< bool >( 56 );
            DailyFrontlineChallenge = parser.ReadColumn< bool >( 57 );
            LevelCapRoulette = parser.ReadColumn< bool >( 58 );
            MentorRoulette = parser.ReadColumn< bool >( 59 );
            Unknown60 = parser.ReadColumn< bool >( 60 );
            Unknown61 = parser.ReadColumn< bool >( 61 );
            Unknown62 = parser.ReadColumn< bool >( 62 );
            Unknown63 = parser.ReadColumn< bool >( 63 );
            Unknown64 = parser.ReadColumn< bool >( 64 );
            AllianceRoulette = parser.ReadColumn< bool >( 65 );
            FeastTeamRoulette = parser.ReadColumn< bool >( 66 );
            NormalRaidRoulette = parser.ReadColumn< bool >( 67 );
            Unknown68 = parser.ReadColumn< bool >( 68 );
            Unknown69 = parser.ReadColumn< bool >( 69 );
            Unknown70 = parser.ReadColumn< bool >( 70 );
            Unknown71 = parser.ReadColumn< bool >( 71 );
            Unknown72 = parser.ReadColumn< bool >( 72 );
            Unknown73 = parser.ReadColumn< bool >( 73 );
            Unknown74 = parser.ReadColumn< bool >( 74 );
            Unknown75 = parser.ReadColumn< bool >( 75 );
            Unknown76 = parser.ReadColumn< bool >( 76 );
            Unknown77 = parser.ReadColumn< bool >( 77 );
            Unknown78 = parser.ReadColumn< bool >( 78 );
            Unknown79 = parser.ReadColumn< bool >( 79 );
            Unknown80 = parser.ReadColumn< bool >( 80 );
            Unknown81 = parser.ReadColumn< bool >( 81 );
            Unknown82 = parser.ReadColumn< bool >( 82 );
            Unknown83 = parser.ReadColumn< bool >( 83 );
            Unknown84 = parser.ReadColumn< bool >( 84 );
            Unknown85 = parser.ReadColumn< bool >( 85 );
            Unknown86 = parser.ReadColumn< bool >( 86 );
            Unknown87 = parser.ReadColumn< bool >( 87 );
            Unknown88 = parser.ReadColumn< bool >( 88 );
            Unknown89 = parser.ReadColumn< bool >( 89 );
            Unknown90 = parser.ReadColumn< bool >( 90 );
            Unknown91 = parser.ReadColumn< bool >( 91 );
        }
    }
}