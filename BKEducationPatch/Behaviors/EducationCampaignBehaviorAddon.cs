using BKEducationPatch.Books;
using TaleWorlds.CampaignSystem;

namespace BKEducationPatch.Behaviors
{
    internal class EducationCampaignBehaviorAddon : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {

        }

        public override void SyncData(IDataStore dataStore)
        {
            dataStore.SyncData("BookLanguages", ref DefaultBookTypesAddOn.bookTypeLanguages);
        }
    }
}
