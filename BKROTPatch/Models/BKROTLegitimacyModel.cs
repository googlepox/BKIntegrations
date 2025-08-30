using BannerKings;
using BannerKings.Behaviours.Diplomacy;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Titles;
using BannerKings.Managers.Titles.Governments;
using BannerKings.Models.BKModels;
using BannerKings.Utils.Models;
using BKROTPatch.Divinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.Core;

namespace BKROTPatch.Models
{
    internal class BKROTLegitimacyModel : BKLegitimacyModel
    {
        public override BKExplainedNumber CalculateKingdomLegitimacy(KingdomDiplomacy diplomacy, bool explanations = false)
        {
            BKExplainedNumber result = base.CalculateKingdomLegitimacy(diplomacy, explanations);
            Hero leader = diplomacy.Kingdom.Leader;
            Religion rel = BannerKingsConfig.Instance.ReligionsManager.GetHeroReligion(leader);
            if (rel != null)
            {
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.TheFather, rel))
                {
                    result.Add(0.1f, ROTDivinities.Instance.TheFather.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.LionOfNight, rel))
                {
                    result.Add(0.1f, ROTDivinities.Instance.LionOfNight.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.FatherOfWaters, rel))
                {
                    result.Add(0.1f, ROTDivinities.Instance.FatherOfWaters.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Trios, rel))
                {
                    result.Add(0.1f, ROTDivinities.Instance.Trios.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.PrincelyArbiter, rel))
                {
                    result.Add(0.1f, ROTDivinities.Instance.PrincelyArbiter.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.GodsBlood, rel))
                {
                    result.Add(0.1f, ROTDivinities.Instance.GodsBlood.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.Harpy, rel))
                {
                    result.Add(0.1f, ROTDivinities.Instance.Harpy.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.GodOnEarth, rel))
                {
                    result.Add(0.1f, ROTDivinities.Instance.GodOnEarth.Name, null);
                }
                if (BannerKingsConfig.Instance.ReligionsManager.HasBlessing(leader, ROTDivinities.Instance.MaidenMadeOfLight, rel))
                {
                    result.Add(0.1f, ROTDivinities.Instance.MaidenMadeOfLight.Name, null);
                }
            }
            return result;
        }
    }
}
