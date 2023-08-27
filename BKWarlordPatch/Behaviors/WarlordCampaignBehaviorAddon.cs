using BKWarlordPatch.Books;
using TaleWorlds.CampaignSystem;

namespace BKWarlordPatch.Behaviors
{
    internal class WarlordCampaignBehaviorAddon : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {

        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("BookLanguages", ref DefaultBookTypesWarlord.bookTypeLanguages);
        }
    }
}
