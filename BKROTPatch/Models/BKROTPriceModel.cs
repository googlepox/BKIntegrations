using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Models.Vanilla;
using BKROTPatch.Divinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;

namespace BKROTPatch.Models
{
    internal class BKROTPriceModel : BKPriceFactorModel
    {
        public override float GetTradePenalty(ItemObject item, MobileParty clientParty, PartyBase merchant, bool isSelling, float inStore, float supply, float demand)
        {
            ExplainedNumber result = new ExplainedNumber(base.GetTradePenalty(item, clientParty, merchant, isSelling, inStore, supply, demand));
            if (clientParty != null)
            {
                Hero hero = clientParty.LeaderHero;
                Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(hero);
                if (hero != null)
                {
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.TheSmith, rel))
                    {
                        result.AddFactor(-0.1f, null);
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.Semosh, rel))
                    {
                        result.AddFactor(-0.1f, null);
                    }
                    if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(hero, ROTDivinities.Instance.MotherRhoyne, rel))
                    {
                        result.AddFactor(-0.1f, null);
                    }
                }
            }
            return result.ResultNumber;
        }
    }
}
