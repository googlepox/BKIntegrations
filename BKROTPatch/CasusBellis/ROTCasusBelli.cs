using BannerKings;
using BannerKings.Behaviours.Diplomacy.Wars;
using BannerKings.CampaignContent.Traits;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BKROTPatch.CasusBellis
{
    internal class ROTCasusBelli : DefaultTypeInitializer<ROTCasusBelli, CasusBelli>
    {
        public CasusBelli DothrakiRaid { get; } = new CasusBelli("dothraki_raid");
        public CasusBelli IronbornRaid { get; } = new CasusBelli("ironborn_raid");
        public CasusBelli DefeatTargaryen { get; } = new CasusBelli("defeat_targaryen");
        public CasusBelli ConquerKingsLanding { get; } = new CasusBelli("kings_landing");
        public CasusBelli BaratheonReconquest { get; } = new CasusBelli("baratheon_reconquest");
        public CasusBelli TargaryenInvasion { get; } = new CasusBelli("targaryen_invasion");
        public override IEnumerable<CasusBelli> All
        {
            get
            {
                yield return DothrakiRaid;
                yield return IronbornRaid;
                yield return DefeatTargaryen;
                yield return ConquerKingsLanding;
                yield return BaratheonReconquest;
                yield return TargaryenInvasion;
            }
        }
        public override void Initialize()
        {
            this.IronbornRaid.Initialize(new TextObject("{=JasbMH20}Great Raid", null), new TextObject("By salt and steel, the Ironborn descend upon foreign shores, taking what is owed to us by right of strength. Such raids bring plunder, thralls, and glory to those who dare the sea.\n\nObjective: Raid 8 or more villages of the enemy's culture.", null), new TextObject("{=mkkNJgAA}Mass Raiding", null), 0.5f, 3f, 0.8f, 5000f, delegate (War war)
            {
                StanceLink attackerLink4 = war.Attacker.GetStanceWith(war.Defender);
                List<Settlement> attackerConquests4 = DiplomacyHelper.GetRaidsInWar(war.Attacker, attackerLink4, null);
                return attackerConquests4.FindAll((Settlement x) => x.Culture == war.Defender.Culture).Count >= 8;
            }, (War war) => war.Defender.Fiefs.Count == 0, delegate (IFaction faction1, IFaction faction2, CasusBelli casusBelli)
            {
                string id2 = faction1.StringId;
                bool hasFiefs2 = faction2.Settlements.ToList<Settlement>().FindAll((Settlement x) => x.IsVillage && x.Culture == faction2.Culture).Count<Settlement>() >= 12;
                return (id2 == "sturgia") && faction2.Culture != faction1.Culture && hasFiefs2;
            }, (Kingdom kingdom) => true, new Dictionary<TraitObject, float>
            {
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just,
                    -0.2f
                },
                {
                    DefaultTraits.Mercy,
                    -0.2f
                },
                {
                    DefaultTraits.Egalitarian,
                    -0.1f
                },
                {
                    DefaultTraits.Valor,
                    0.2f
                },
                {
                    DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious,
                    0.1f
                }
            }, new TextObject("{=RyUztoR1}The {ATTACKER} ride out for a great raid! {DEFENDER} towns and villages will be razed to the ground.", null), false, false, null, null);
        }
    }
}
